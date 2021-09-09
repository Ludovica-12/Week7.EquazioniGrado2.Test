using System;
using Week7.EquazioniGrado2.Core;
using Xunit;

namespace Week7.EquazioniGrado2.Test
{
    public class EquazioneTest
    {
        [Fact] //Significa che si tratta di un test
        public void Test1()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();
            //ACT : chiamata alla funzione da testare
            double[] risultato = equazione.RisolviequazioniDiSecondoGrado(1, -3, 2);

            //Assert: verifica del risultato
            Assert.True(risultato.Length == 2);
            Assert.Equal(1, risultato[0]);// alternativa Assert.True(risultato[0] == 1);
            
            Assert.Equal(2, risultato[1]);

        }
        public void Test2()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();
            //ACT : chiamata alla funzione da testare
            double[] risultato = equazione.RisolviequazioniDiSecondoGrado(1, -5, 6);

            //Assert: verifica del risultato
            Assert.True(risultato.Length == 2);
            Assert.Equal(2, risultato[0]);// alternativa Assert.True(risultato[0] == 1);

            Assert.Equal(3, risultato[1]);

        }

        public void Test3()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();
            //ACT : chiamata alla funzione da testare
            double[] risultato = equazione.RisolviequazioniDiSecondoGrado(1, 2, 1);

            //Assert: verifica del risultato
            Assert.True(risultato.Length == 1);

            Assert.Equal(-1, risultato[0]);

        }

        public void Test4()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();
            //ACT : chiamata alla funzione da testare
            double[] risultato = equazione.RisolviequazioniDiSecondoGrado(1, -3, 10);

            //Assert: verifica del risultato
            Assert.True(risultato == null);

        }

    }
}
