using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfP15.Models;

namespace WpfP15.Service
{
    public class DBService
    {
        private Prak15MenshContext context;
        public Prak15MenshContext Context => context;

        private static DBService? instance;

        public static DBService Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBService();
                return instance;
            }
        }
        private DBService()
        {
            context = new Prak15MenshContext();
        }
    }
}
