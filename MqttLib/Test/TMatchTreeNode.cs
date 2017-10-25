using Moq;
using Xunit;
using System.Collections.Generic;


namespace MqttLib.MatchTree.Test
{
    public class TMatchTree
    {
        /// <summary>
        /// <author>王添，3114001577</author>
        /// </summary>
        [Theory]
        [InlineData("sport/tennis/player1/#",true)]
        [InlineData("sport/#",true)]
        [InlineData("sport/tennis#",false)]
        [InlineData("sport/tennis/#/ranking",false)]
        [InlineData("#",true)]
        [InlineData("sport/tennis/+",true)]
        [InlineData("+",true)]
        [InlineData("++",false)]
        [InlineData("+/tennis/#",true)]
        [InlineData("sport+",false)]
        [InlineData("sport/+/player1",true)]
        [InlineData("/",true)]
        [InlineData("Accounts payable",true)]
        public void InitTopic(string topicname,bool canChange)
        {
            Topic topic = null;
            bool getObject = true;
            try
            {
                topic = new Topic(topicname);
            }
            catch (System.ArgumentException ae){
                getObject = false;
            }
            finally
            {
                Assert.Equal(canChange, getObject);
                if (getObject)
                {
                    string[] level = (topicname).Split('/');
                    Assert.Equal(level, topic.Levels);
                }
            }
        }

        [Fact]
        public void TestTopicNode()
        {
            //测试无值构造函数，值容器是否为空
            TopicNode<int> topicNode = new TopicNode<int>("sport/tennis/player1");
            Assert.Equal("sport/tennis/player1", topicNode.Nodevalue);
            Assert.Empty(topicNode.Values);

            //测试加入叶子主题后，值容器是否为空
            topicNode.AddTopicValue(new Topic("sport/tennis/player1/ranking"), 3, 60);
            topicNode.AddTopicValue(new Topic("sport/tennis/player1/score/wimbledon"), 3, 100); 
            Assert.Empty(topicNode.Values);

            //测试主题匹配功能，匹配总数目为3,但只有两个有值，结果为2
            List<int> matchList = new List<int>();
            topicNode.CollectMatches(new Topic("sport/tennis/player1/#"), 3, matchList);    
            Assert.Equal(2,matchList.Count);
            Assert.Contains(60,matchList);
            Assert.Contains(100, matchList);

            //为根主题加入值
            topicNode.AddTopicValue(new Topic("sport/tennis/player1"), 3, 288);
            Assert.Single(topicNode.Values);

            //为单一主题加入多值测试
            matchList = new List<int>();
            topicNode.AddTopicValue(new Topic("sport/tennis/player1"), 3, 289);
            topicNode.AddTopicValue(new Topic("sport/tennis/player1"), 3, 290);
            topicNode.CollectMatches(new Topic("sport/tennis/player1"), 3, matchList);
            Assert.Equal(3, matchList.Count);
            Assert.Contains(288, matchList); Assert.Contains(289, matchList);
            Assert.Contains(290, matchList);

            //测试移除某一主题值后的匹配问题
            matchList = new List<int>();
            topicNode.Remove(new Topic("sport/tennis/player1"), 3, 289);
            topicNode.CollectMatches(new Topic("sport/tennis/player1"), 3, matchList);
            Assert.Equal(2, matchList.Count);
            Assert.Contains(288, matchList);
            Assert.DoesNotContain(289, matchList);
            Assert.Contains(290, matchList);

            //测试移除所有主题下某个值得匹配问题，需要先存在相同值
            matchList = new List<int>();
            topicNode.AddTopicValue(new Topic("sport/tennis/player1/ranking"), 3, 288);
            topicNode.CollectMatches(new Topic("sport/tennis/player1/ranking"), 3, matchList);
            Assert.Equal(2, matchList.Count);
            Assert.Contains(288, matchList);
            topicNode.RemoveAll(288);
            matchList = new List<int>();
            topicNode.CollectMatches(new Topic("sport/tennis/player1/ranking"), 3, matchList);
            Assert.Single(matchList);
            Assert.DoesNotContain(288, matchList);
            matchList = new List<int>();
            topicNode.CollectMatches(new Topic("sport/tennis/player1"), 3, matchList);
            Assert.Single(matchList);
            Assert.DoesNotContain(288, matchList);
            matchList = new List<int>();
            topicNode.CollectMatches(new Topic("sport/tennis/player1/#"), 3, matchList);
            Assert.DoesNotContain(288, matchList);
        }

        [Fact] 
        public void TestTopicTree()
        {
            //因为树节点的测试类似，树从根开始，仅测试不同部分
            //测试无节点时的树根
            TopicTree<int> topicTree = new TopicTree<int>();
            Assert.Equal(".",topicTree.rootNode.Nodevalue);
            List<int> matchlist = topicTree.CollectMatches("#");
            Assert.Empty(matchlist);

            topicTree.Add(new Topic("work"), 20);

            topicTree.Add(new Topic("sport/ball/football"), 5);
            topicTree.Add(new Topic("sport/ball/longrun"), 6);
            topicTree.Add(new Topic("sport/run/longrun"), 8);
            topicTree.Add(new Topic("sport/run/shortrun"), 10);
            matchlist =topicTree.CollectMatches("#");
            Assert.Equal(5,matchlist.Count);
            matchlist = topicTree.CollectMatches("sport/#");
            Assert.Equal(4, matchlist.Count);
            matchlist = topicTree.CollectMatches("sport/+/longrun");
            Assert.Equal(2, matchlist.Count);

            topicTree.RemoveAll();
            matchlist = topicTree.CollectMatches("#");
            Assert.Empty(matchlist);

        }
    }
}
