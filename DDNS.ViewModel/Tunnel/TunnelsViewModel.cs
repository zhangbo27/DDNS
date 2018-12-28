﻿using System;

namespace DDNS.ViewModel.Tunnel
{
    public class TunnelsViewModel
    {
        public string TunnelProtocol { get; set; }

        public string TunnelName { get; set; }

        public string SubDomain { get; set; }

        public string LocalPort { get; set; }
    }

    public class AdminTunnelsViewModel : TunnelsViewModel
    {
        public DateTime? ExpiredTime { get; set; }

        public string FullUrl { get; set; }
    }
}