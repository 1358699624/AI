using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;
using AI;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using static AI.SentimentModel;

/*

byte[] buffer = File.ReadAllBytes(@"C:\Users\m\Desktop\ssq.json");

string s = Encoding.UTF8.GetString(buffer);

JObject obj = JObject.Parse(s);

List<SSQClass> root = JsonConvert.DeserializeObject<List<SSQClass>>(obj["result"].ToString());
StringBuilder StringBuildersb = new StringBuilder();string reds = "";for (int i = 0; i < root.Count; i++)
{
    reds = root[i].red;
    string[] str = reds.Split(",");
    StringBuildersb.Append($"insert  into T_CaiPiao (qishu,AAA001,AAA002,AAA003,AAA004,AAA005,AAA006,AAE001,year) values({root[i].code},{str[0]},{str[1]},{str[2]},{str[3]},{str[4]},{str[5]},{root[i].blue},{root[i].code.Substring(0, 4)});");
    
}SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=LotteryDB;Integrated Security=True");conn.Open();string str23 = StringBuildersb.ToString();SqlCommand comm = new SqlCommand(str23, conn);
int i_ = comm.ExecuteNonQuery();conn.Close();*/

var input = new ModelInput();
input.AAA001 = "2022/01/01";
ModelOutput resulttotal = SentimentModel_ConsoleApp3.Predict(input);
Console.WriteLine(resulttotal.Score.ToString());
Console.Read();
Console.ReadLine();