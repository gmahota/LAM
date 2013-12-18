using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAM.Model
{
    public delegate void BalcaoUpdateEventHandler(object sender, BalcaoUpdateEventArgs e);

    /// <summary>
    /// Summary description for Counter.
    /// </summary>
    public class EnventoBalcao
    {
        public event BalcaoUpdateEventHandler balcaoReached;

        public EnventoBalcao()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public void ActulizaBalcao(int balcao)
        {
           BalcaoUpdateEventArgs e = new BalcaoUpdateEventArgs(balcao);
           OnBalcaoUpdate(e);
           return;//don't count any more
        }

        protected virtual void OnBalcaoUpdate(BalcaoUpdateEventArgs e)
        {
            if (balcaoReached != null)
            {
                balcaoReached(null, e);
            }
        }
    }

    public class BalcaoUpdateEventArgs : EventArgs
    {
        private int _balcao;
        public BalcaoUpdateEventArgs(int balcao)
        {
            this._balcao = balcao;
        }

        public int getBalcao
        {
            get
            {
                return _balcao;
            }
        }
    }
}
