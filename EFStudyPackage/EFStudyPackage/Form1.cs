using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFStudyPackage
{
    public partial class Form1 : Form
    {
        string strConn = "Data Source=MOONSOUL-NOTEPC;"
                  + "Initial Catalog=EFStudy;"
                  + "Persist Security Info = true;"
                  + "User ID=sa;Password=moon4163;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BreakAwayContext>());

            var destination = new Destination
            {
                Country     = "Indonesia",
                Description = "Ecotourism at its best in exquisite Bali",
                Name        = "Bali"
            };

            using (var context = new BreakAwayContext(strConn))
            {
                context.Destinations.Add(destination);
                context.SaveChanges();
            }
        }

        private void btn_Test_GuidPk_Click(object sender, EventArgs e)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BreakAwayContext>());

            var trip = new Trip
            {
                StartDate = new DateTime(1983,3,25),
                EndDate   = new DateTime(2014, 2, 20),
                CostUSD   = 800
            };

            using (var context = new BreakAwayContext(strConn))
            {
                context.Trips.Add(trip);
                context.SaveChanges();
            }

        }
    }
}
