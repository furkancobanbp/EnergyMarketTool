using jsonParser;
using jsonParser.Model;
using System;
using System.Collections.Generic;
using System.Windows;
using WPFTutorial.Functions;

namespace WPFTutorial
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public interface SistemYonu
    {
        public String? SistemYonu { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        queries query = new queries();
        restApi api = new restApi();
        clsPiyasaFiyatlariModel model = new clsPiyasaFiyatlariModel();
        List<clsPiyasaFiyatlariModel> fiyatList = new List<clsPiyasaFiyatlariModel>();
        List<clsDgpTalimatOzet> dgpList = new List<clsDgpTalimatOzet>();
        clsDgpTalimatOzet dgpModel = new clsDgpTalimatOzet();
        private void btnPtfSmfCek_Copy_Click(object sender, RoutedEventArgs e)
        {
            Grid1.ItemsSource = query.piyasaFiyatCek(BasTar.SelectedDate.Value, BitTar.SelectedDate.Value);
        }
        private void btnPtfSmfCek_Click(object sender, RoutedEventArgs e)
        {
            fiyatList = api.getPtfSmf(BasTar.SelectedDate.Value, BitTar.SelectedDate.Value);
            if (fiyatList.Count == 0)
            {
                MessageBox.Show("İlgili Tarihte Veri Bulunamadı", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            bool insertOrUpdate = false;
            using (var contex = new context())
            {
                foreach (clsPiyasaFiyatlariModel i in fiyatList)
                {
                    model = (clsPiyasaFiyatlariModel)api.translateToTurkish(i);
                    try
                    {
                        contex.tblPiyasaFiyatlari.Add(model);
                        contex.SaveChanges();
                    }
                    catch
                    {
                        insertOrUpdate = true;
                    }
                    finally
                    {
                        if (insertOrUpdate)
                        {
                            contex.tblPiyasaFiyatlari.Update(model);
                            contex.SaveChanges();
                        }
                        insertOrUpdate = false;
                    }
                }
                MessageBox.Show("İşlem Tamamlandı");
            }
        }
        private void btnDGPDurum_click(object sender, RoutedEventArgs e)
        {
            dgpList = api.dgpTalimatOzet(BasTar.SelectedDate.Value, BitTar.SelectedDate.Value);
            if (dgpList.Count == 0)
            {
                MessageBox.Show("İlgili Tarihte Veri Bulunamadı", "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            bool insertOrUpdate = false;
            using (var contex = new context())
            {
                foreach (clsDgpTalimatOzet i in dgpList)
                {
                    dgpModel = (clsDgpTalimatOzet)api.translateToTurkish(i);
                    try
                    {
                        contex.tblDgpOzet.Add(dgpModel);
                        contex.SaveChanges();
                    }
                    catch
                    {
                        insertOrUpdate = true;
                    }
                    finally
                    {
                        if (insertOrUpdate)
                        {
                            contex.tblDgpOzet.Update(dgpModel);
                            contex.SaveChanges();
                        }
                        insertOrUpdate = false;
                    }
                }
                MessageBox.Show("İşlem Tamamlandı");
            }
        }
        private void btnDGPDurum_Listele(object sender, RoutedEventArgs e)
        {
            Grid2.ItemsSource = query.dgpOzetCek(BasTar.SelectedDate.Value, BitTar.SelectedDate.Value);
        }
    }
}
