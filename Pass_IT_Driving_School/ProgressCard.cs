using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_IT_Driving_School
{
    public partial class ProgressCard : Form
    {
        public static ProgressCard progressCard;
        public Label firstname, lastname;
        public ProgressCard()
        {
            InitializeComponent();
            progressCard = this;
            firstname = lblFirstName;
            lastname = lblSecondName;
        }

        private void ProgressCard_Load(object sender, EventArgs e)
        {
            LoadProgress();
        }
             

        public void LoadProgress()
        {
            string[,] rows = new string[,]
          {
                {"17 September 2023","1" },
                {"18 September 2023","1" },
                {"19 September 2023","1" },
                {"20 September 2023","1" },
                {"21 September 2023","1" },
                {"22 September 2023","1" },
          };

            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string[] row = new string[rows.GetLength(1)];
                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                }
                gvProgressReport.Rows.Add(row);
            }
        }
    }
}
