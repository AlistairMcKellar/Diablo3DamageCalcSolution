using D3DataContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Diablo3DamageCalc.Models
{
    public class ProfileModel
    {
        public PlayerProfile PlayerProfile { get; private set; }

        public ProfileModel(PlayerProfile playerProfile)
        {
            PlayerProfile = playerProfile;
        }
    }
    }