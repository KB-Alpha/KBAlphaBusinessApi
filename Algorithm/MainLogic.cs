using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KBAlphaBusinessApi.Algorithm
{

    //This method runs all the logic that needs to be executed seqentially
    public class MainLogic : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await AutoTrade();
        }


        //Once Interactive brockers is live, this method is for auto trading on a schedule
        private async Task AutoTrade()
        {
            Debug.WriteLine("Running the Auto trade protocol @" + DateTime.Now.ToString());
        }
    }
}
