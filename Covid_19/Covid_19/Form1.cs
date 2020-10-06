using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class Covid19 : Form
    {
        private MongoDB mongoDB;

        protected List<BsonDocument> confirmedCases;
        protected List<BsonDocument> confirmedDeaths;
        protected List<BsonDocument> confirmedRecovered;

        protected List<string> dates;

        private List<int> totalCases;
        private List<int> deaths;
        private List<int> recoverd;


        public Covid19()
        {
            InitializeComponent();

            mongoDB = new MongoDB();

            confirmedCases = mongoDB.GetConfirmedCases();
            confirmedDeaths = mongoDB.GetDeathCases();
            confirmedRecovered = mongoDB.GetRecoveredCases();

            dates = getDates();

            totalCases = ConfirmedCasesNumbers();
            deaths = ConfirmedDeathsNumbers();
            recoverd = ConfirmedRecoveredNumbers();

            FillChart();
        }
        
        private void FillChart()
        {

           
            //line confirmed
            for (int a  = 0; a < dates.Count; a++)
            {
                Covid19Chart.Series["confirmedCases"].Points.AddXY(dates[a].ToString(), totalCases[a].ToString());
            }

            //line Deaths
            for (int b = 0; b < confirmedRecovered.Count; b++)
            {
                Covid19Chart.Series["confirmedDeaths"].Points.AddXY(dates[b].ToString(), deaths[b].ToString());
            }

            //line Recovered
            for(int c = 0; c < confirmedRecovered.Count; c++)
            {
                Covid19Chart.Series["confirmedRecovered"].Points.AddXY(dates[c].ToString(), recoverd[c].ToString());
            }


            //chart title  
            Covid19Chart.Titles.Add("Confirmed Corona Cases Chart");
        }

        public List<string> getDates()
        {
            BsonDocument bsonDocument = confirmedCases[1];

            List<string> dates = new List<string>();

            for (int i = 4; i < bsonDocument.Count(); i++)
            {
                dates.Add(bsonDocument.GetElement(i).Name);
            }

            return dates;
        }


        public List<int> ConfirmedCasesNumbers()
        {
            List<int> numbers = new List<int>();
            int total = 0;

            for(int i = 0; i < dates.Count; i++)
            {
                for(int y = 0; y < confirmedCases.Count; y++)
                {
                     total += int.Parse(confirmedCases[y].GetValue(dates[i]).ToString());
                }

                numbers.Add(total);
            }


            return numbers;
        }

        public List<int> ConfirmedDeathsNumbers()
        {
            List<int> numbers = new List<int>();
            int total = 0;

            for (int i = 0; i < dates.Count; i++)
            {
                for (int y = 0; y < confirmedDeaths.Count; y++)
                {
                    total += int.Parse(confirmedDeaths[y].GetValue(dates[i]).ToString());
                }

                numbers.Add(total);
            }


            return numbers;
        }

        public List<int> ConfirmedRecoveredNumbers()
        {
            List<int> numbers = new List<int>();
            int total = 0;

            for (int i = 0; i < dates.Count; i++)
            {
                for (int y = 0; y < confirmedRecovered.Count; y++)
                {
                    total += int.Parse(confirmedRecovered[y].GetValue(dates[i]).ToString());
                }

                numbers.Add(total);
            }


            return numbers;
        }

    }
}
