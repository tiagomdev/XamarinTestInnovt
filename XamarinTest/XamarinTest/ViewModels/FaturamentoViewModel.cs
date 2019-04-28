using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using XamarinTest.Models;
using XamarinTest.Views;

namespace XamarinTest.ViewModels
{
    public class FaturamentoViewModel : BaseViewModel
    {
        ObservableCollection<FaturamentoDetalhe> faturamentoLista;
        public ObservableCollection<FaturamentoDetalhe> FaturamentoLista { get { return faturamentoLista; } set { SetProperty(ref faturamentoLista, value); } }

        public FaturamentoViewModel()
        {
            FaturamentoLista = new ObservableCollection<FaturamentoDetalhe>();

            FaturamentoLista.Add(new FaturamentoDetalhe("03/05", "100.000.000", "R$ 1.200.200,00"));
            FaturamentoLista.Add(new FaturamentoDetalhe("03/05", "100.000.000", "R$ 1.200.200,00"));
            FaturamentoLista.Add(new FaturamentoDetalhe("03/05", "100.000.000", "R$ 1.200.200,00"));
            FaturamentoLista.Add(new FaturamentoDetalhe("03/05", "100.000.000", "R$ 1.200.200,00"));
        }
    }

    public class FaturamentoDetalhe
    {
        public FaturamentoDetalhe(string data, string ingresso, string faturamento)
        {
            Data = data;
            Ingresso = ingresso;
            Faturamento = faturamento;
        }

        public string Data { get; set; }
        public string Ingresso { get; set; }
        public string Faturamento { get; set; }
    }
}