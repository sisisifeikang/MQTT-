using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttClient
{
    public class DataTableToJson
    {
        private static Random Random = new Random();

        public static string ToJson(DataTable dataTable)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{");
            foreach(DataRow dr in dataTable.Rows)
            {
                string strPro = dr["Property"].ToString();
                string strDes = dr["Description"].ToString();
                string strValueType = strDes.Split(':')[0];
                string strVale= strDes.Split(':')[1];

                switch (strValueType)
                {
                    case "System.String":
                        stringBuilder.Append("\""+strPro + "\":" + strVale + ",");
                        break;
                    case "System.Int32":
                        int min=0, max=0;
                        int.TryParse(strVale.Split('/')[0],out min);
                        int.TryParse(strVale.Split('/')[1], out max);
                        stringBuilder.Append("\"" + strPro + "\":" + Random.Next(min, max) + ",");
                        break;
                    case "System.Single":
                        float minF = 0, maxF = 0;
                        float.TryParse(strVale.Split('/')[0], out minF);
                        float.TryParse(strVale.Split('/')[1], out maxF);
                        stringBuilder.Append("\"" + strPro + "\":" + (Random.NextDouble()*(maxF-minF)+minF) + ",");

                        break;
                }
                
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }
}
