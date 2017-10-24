using Moq;
using Xunit;


namespace MqttLib.MatchTree.Test
{
    public class TMatchTree
    {
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
    }
}
