using DemoWpf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DemoWpf.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private Athlete _primoAtleta;

        public Athlete PrimoAtleta
        {
            get { return _primoAtleta; }
            set { 
                _primoAtleta = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("PrimoAtleta"));
            }
        }

        private Athlete _atletaRandom;

        public Athlete AtletaRandom
        {
            get { return _atletaRandom; }
            set { 
                _atletaRandom = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("AtletaRandom"));
            }
        }

        private int _numeriPrimi;

        public int NumeriPrimi
        {
            get { return _numeriPrimi; }
            set { 
                _numeriPrimi = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("NumeriPrimi"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async Task getPrimoAtleta()
        {
            using (var context = new OlympicsContext())
            {
                PrimoAtleta = await context.Athletes.FirstOrDefaultAsync();
            }
        }
        public void getAtletaRandom()
        {
            //Esercizio rendere il metodo aincrono con ContinueWith
            using(var context = new OlympicsContext())
            {
                int atleti = context.Athletes.Count();
                Random rnd = new Random();
                while (true)
                {
                    int idAthlete = rnd.Next(atleti);
                    AtletaRandom = context.Athletes.FirstOrDefault(q=> q.IdAthlete == idAthlete);
                    if (AtletaRandom != null) return;
                }
            }
        }

        public void getNumeriPrimi(int n)
        {
            bool[] numeri = new bool[n+1];
            numeri[0] = false;
            numeri[1] = false;
            for (int i = 2; i<numeri.Length; i++)
                numeri[i] = true;

            for (int i = 2; i<=Math.Sqrt(n); i++)
            {
                for (int j = i * 2; j <= n; j += i)
                    numeri[j] = false;
            }

            NumeriPrimi = numeri.Count(c => c == true);
        }
    }
}
