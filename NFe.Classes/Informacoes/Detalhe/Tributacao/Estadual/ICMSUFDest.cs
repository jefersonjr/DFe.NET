﻿namespace NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual
{
    public class ICMSUFDest
    {
        private decimal _vBcufDest;
        private decimal _pFcpufDest;
        private decimal _pIcmsufDest;
        private decimal _pIcmsInter;
        private decimal _pIcmsInterPart;
        private decimal _vFcpufDest;
        private decimal _vIcmsufDest;
        private decimal _vIcmsufRemet;

        /// <summary>
        /// NA03 - Valor da BC do ICMS na UF de destino
        /// </summary>
        public decimal vBCUFDest
        {
            get { return _vBcufDest; }
            set { _vBcufDest = Valor.Arredondar(value, 2); }
        }

        /// <summary>
        /// NA05 - Percentual do ICMS relativo ao Fundo de Combate à Pobreza (FCP) na UF de destino
        /// </summary>
        public decimal pFCPUFDest
        {
            get { return _pFcpufDest; }
            set
            {
                _pFcpufDest = Valor.Arredondar(value, 4); }
        }

        /// <summary>
        /// NA07 - Alíquota interna da UF de destino
        /// </summary>
        public decimal pICMSUFDest
        {
            get { return _pIcmsufDest; }
            set { _pIcmsufDest = Valor.Arredondar(value, 4); }
        }

        /// <summary>
        /// NA09 - Alíquota interestadual das UF envolvidas
        /// </summary>
        public decimal pICMSInter
        {
            get { return _pIcmsInter; }
            set { _pIcmsInter = Valor.Arredondar(value, 2); }
        }

        /// <summary>
        /// NA11 - Percentual provisório de partilha do ICMS Interestadual
        /// </summary>
        public decimal pICMSInterPart
        {
            get { return _pIcmsInterPart; }
            set { _pIcmsInterPart = Valor.Arredondar(value, 4); }
        }

        /// <summary>
        /// NA13 - Valor do ICMS relativo ao Fundo de Combate à Pobreza(FCP) da UF de destino
        /// </summary>
        public decimal vFCPUFDest
        {
            get { return _vFcpufDest; }
            set { _vFcpufDest = Valor.Arredondar(value, 2); }
        }

        /// <summary>
        /// NA15 - Valor do ICMS Interestadual para a UF de destino
        /// </summary>
        public decimal vICMSUFDest
        {
            get { return _vIcmsufDest; }
            set { _vIcmsufDest = Valor.Arredondar(value, 2); }
        }

        /// <summary>
        /// NA17 - Valor do ICMS Interestadual para a UF do remetente
        /// </summary>
        public decimal vICMSUFRemet
        {
            get { return _vIcmsufRemet; }
            set { _vIcmsufRemet = Valor.Arredondar(value, 2); }
        }
    }
}