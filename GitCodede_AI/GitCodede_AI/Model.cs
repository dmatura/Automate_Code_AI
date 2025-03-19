using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCodede_AI
{

    internal class IAIModelBase<T> : IAIModelBase
    {
        public IAIModelBase()
        {
        }



    }

    internal class IAIModelBase<T, T1> : IAIModelBase<T>
    {
        public IAIModelBase()
        {

        }
    }

    internal class AIModelLLMCodeReview : IAIModelBase
    {

    }
}
