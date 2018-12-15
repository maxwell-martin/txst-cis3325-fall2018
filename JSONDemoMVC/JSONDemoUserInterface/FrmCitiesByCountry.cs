using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSONDemoBCL;

namespace JSONDemoUserInterface
{
    public partial class FrmCitiesByCountry : Form
    {
        List<City> listOfCities = new List<City>();

        public FrmCitiesByCountry()
        {
            InitializeComponent();
        }

        private void FrmCitiesByCountry_Load(object sender, EventArgs e)
        {
            BusinessLogicClass myBLC = new BusinessLogicClass();
            string url = "http://www.conkave.com/iosdemos/json.php";

            listOfCities = myBLC.RequestDataFromAPI_URL(url);

            var countries = (from city in listOfCities
                             orderby city.Country
                             select new { city.Country }).Distinct().ToList();

            cboCountries.DisplayMember = "Country";
            cboCountries.ValueMember = "Country";
            cboCountries.DataSource = countries;

            cboCountries.SelectedIndex = -1;
        }

        private void CboCountries_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedCountry = cboCountries.SelectedValue.ToString();

            var cities = (from city in listOfCities
                          where city.Country == selectedCountry
                          orderby city.CityName
                          select city).ToList();

            dgvCities.DataSource = cities;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
