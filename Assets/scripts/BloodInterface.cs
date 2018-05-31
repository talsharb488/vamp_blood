using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vamp_bood_api;

namespace vamp_api
{
    interface BloodInterface{

        Boolean isAccepting(BLOOD_TYPE host, BLOOD_TYPE recieving);
        Boolean isRejecting(BLOOD_TYPE host, BLOOD_TYPE recieving);
);



    }
