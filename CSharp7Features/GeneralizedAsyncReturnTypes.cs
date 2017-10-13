using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7Features
{
    class GeneralizedAsyncReturnTypes
    {
        public async ValueTask<int> Func()
        {
            await Task.Delay(100);
            return 5;
        }
    }
}
