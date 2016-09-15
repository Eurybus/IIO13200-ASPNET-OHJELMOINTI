using System;
using System.Configuration; //Web.config lukemista varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IkkunaLaskuriProper
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                double resultPer, resultArea, resultBzlArea;

                double width = double.Parse(fieldWidth.Text) / 1000;
                double height = double.Parse(fieldHeight.Text) / 1000;
                double bzlWidth = double.Parse(fieldFrameWidth.Text) /1000;

                resultBzlArea = BezelCalculatePerimerer(bzlWidth, width, height);
                resultPer = width * 2 + height * 2;
                //resultArea = (width - (2 * resultBzlArea)) * (height - (2 * resultBzlArea));
                resultArea = width * height;

                updateValues(resultBzlArea, resultPer, resultArea, calculatePrice(resultArea, resultPer));
            }
            catch (Exception ex)
            {
                lblMessages.Text = ex.Message + "Stacktrace: " + ex.StackTrace;
            }
            finally
            {
                //lblMessages.Text = "";
            }
        }

        public static double BezelCalculatePerimerer(double bzlwidth, double xLength, double yLength)
        {
            return ((bzlwidth * xLength) * 2) + ((bzlwidth * yLength) * 2);
        }
        private void updateValues(double bzlArea, double perimeter, double area, double price)
        {
            lblArea.Text = area.ToString();
            lblPerimeter.Text = perimeter.ToString();
            lblPrice.Text = price.ToString();
        }
        private double calculatePrice(double area, double bzlPer)
        {
            double margin = double.Parse(ConfigurationManager.AppSettings["salesMargin"]) / 10;
            double glassSqPrice = double.Parse(ConfigurationManager.AppSettings["glassSqPrice"]);
            double workPrice = double.Parse(ConfigurationManager.AppSettings["workPrice"]);
            double aluLineMeterPrice = double.Parse(ConfigurationManager.AppSettings["aluminiumLinealMeter"]);

            return (1 + margin) * ((area * glassSqPrice) + (bzlPer * aluLineMeterPrice) + workPrice);
        }
    }
}