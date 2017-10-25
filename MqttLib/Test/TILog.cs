using Xunit;
using Moq;

namespace MqttLib.Logger.Test
{
    public class TLog
    {
        /// <summary>
        /// <author>彭冠钦，3114001573</author>
        /// </summary>
        [Fact]
        public void TestILog()
        {
            var log = Mock.Of<ILog>();
            Assert.Equal(LogLevel.DEV, log.LoggingLevel);

            log.LoggingLevel = LogLevel.DEBUG;
            Assert.Equal(LogLevel.DEBUG, log.LoggingLevel);

            log.LoggingLevel = LogLevel.INFO;
            Assert.Equal(LogLevel.INFO, log.LoggingLevel);

            log.LoggingLevel = LogLevel.ERROR;
            Assert.Equal(LogLevel.ERROR, log.LoggingLevel);

            log.LoggingLevel = LogLevel.CRITICAL;
            Assert.Equal(LogLevel.CRITICAL, log.LoggingLevel);
        }
        /// <summary>
        /// <author>彭冠钦，3114001573</author>
        /// </summary>
        [Fact]        
        public void TestLogOnlyName()
        {
            string tempGuid = System.Guid.NewGuid().ToString();
            var fileLog = new FileLog(tempGuid);

            Assert.Equal(LogLevel.DEV, fileLog.LoggingLevel);
            Assert.Equal(LogFileModes.ROTATE,fileLog.Mode);
            Assert.Equal(tempGuid, fileLog.Name);
            string fileName = System.IO.Directory.GetCurrentDirectory() + "\\" + tempGuid + ".log";
            Assert.Equal(fileName, fileLog.Filename);
            bool existFile = System.IO.File.Exists
                (System.IO.Directory.GetCurrentDirectory() + "\\" + tempGuid + ".log")
                ? true : false;
            Assert.True(existFile);
            fileLog.Write("WriteMessage");
            //测试单次文件写入
            using (System.IO.StreamReader streamReader = new System.IO.StreamReader(fileName))
            {
                bool existWriteMessage = streamReader.ReadToEnd().Contains("WriteMessage") ? true : false;
                Assert.True(existWriteMessage);
                streamReader.Close();
            }
        }
        /// <summary>
        /// <author>陈福铭，3114001557</author>
        /// </summary>
        [Fact]
        public void TestLogWriteLevel()
        {
            string tempGuid = System.Guid.NewGuid().ToString();
            var fileLog = new FileLog(tempGuid);
            //测试写入比日志等级还要低的信息
            fileLog.LoggingLevel = LogLevel.ERROR;
            Assert.Equal(LogLevel.ERROR, fileLog.LoggingLevel);

            string fileName = System.IO.Directory.GetCurrentDirectory() + "\\" + tempGuid + ".log";
            Assert.Equal(fileName, fileLog.Filename);

            fileLog.Write(LogLevel.DEBUG, "DEBUG Message");
            using (System.IO.StreamReader streamReader = new System.IO.StreamReader(fileName))
            {
                bool existWriteMessage = streamReader.ReadToEnd().Contains("DEBUG Message") ? true : false;
                Assert.False(existWriteMessage);
                streamReader.Close();
            }

            fileLog.Write(LogLevel.CRITICAL, "CRITICAL Message");
            using (System.IO.StreamReader streamReader = new System.IO.StreamReader(fileName))
            {
                bool existWriteMessage = streamReader.ReadToEnd().Contains("CRITICAL Message") ? true : false;
                Assert.True(existWriteMessage);
                streamReader.Close();
            }
        }
        /// <summary>
        /// <author>陈福铭，3114001557</author>
        /// </summary>
        [Fact]
        public void TestLogWriteModeAndSize()
        {
            string tempGuid = System.Guid.NewGuid().ToString();
            var fileLog = new FileLog(tempGuid);
            fileLog.Mode = LogFileModes.ROTATE;
            fileLog.MaxSize = 0;
            string fileName = System.IO.Directory.GetCurrentDirectory() + "\\" + tempGuid + ".log";

            fileLog.Write("lastmessage");
            using (System.IO.StreamReader streamReader = new System.IO.StreamReader(fileName))
            {
                bool existlastmessage = streamReader.ReadToEnd().Contains("lastmessage") ? true : false;
                Assert.True(existlastmessage);
                streamReader.Close();
            }
            fileLog.Write("nextmessage");
            using (System.IO.StreamReader streamReader = new System.IO.StreamReader(fileName))
            {
                string tempStr = streamReader.ReadToEnd();
                bool existlastmessage = tempStr.Contains("lastmessage") ? true : false;
                Assert.False(existlastmessage);
                bool existnextmessage = tempStr.Contains("nextmessage") ? true : false;
                Assert.True(existnextmessage);
                streamReader.Close();
            }
            fileLog.Mode = LogFileModes.SEPARATE;
            fileLog.Write("SEPARATE");
            string[] fileArr = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory(),
                "*.log",System.IO.SearchOption.TopDirectoryOnly);
            System.Collections.Generic.List<string> matchfileList = new System.Collections.Generic.List<string>() ;
            foreach(string file in fileArr)
            {
                if (file.Contains(tempGuid)) matchfileList.Add(file);
            }
            Assert.Equal(2, matchfileList.Count);
        }



    }
}
