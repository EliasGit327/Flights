using System;
using System.Collections.Generic;

namespace Flights.API
{
    public partial class Config
    {
        public int Rowid { get; set; }
        public string Cname { get; set; }
        public int? KundenId { get; set; }
        public string Version { get; set; }
        public string Modus { get; set; }
        public string Transfer { get; set; }
        public string Ablauf { get; set; }
        public string Checkintervall { get; set; }
        public string Delay1check { get; set; }
        public string ViaCollector { get; set; }
        public string Usb2lanOnoff { get; set; }
        public string OffsetAuf { get; set; }
        public string OffsetZu { get; set; }
        public string OffsetReboot { get; set; }
        public string Gateway { get; set; }
        public string Server { get; set; }
        public string _2ndserver { get; set; }
        public string Screenshot { get; set; }
        public string Minhdd { get; set; }
        public string Maxuptime { get; set; }
        public string Skalierung { get; set; }
        public string FgWindow { get; set; }
        public string Clickfgwindow { get; set; }
        public string Clickfgx { get; set; }
        public string Clickfgy { get; set; }
        public string Dienst1 { get; set; }
        public string Dienst2 { get; set; }
        public string Dienst3 { get; set; }
        public string Dienst4 { get; set; }
        public string Dienst5 { get; set; }
        public string Prozess1 { get; set; }
        public string Prozess2 { get; set; }
        public string Prozess3 { get; set; }
        public string Prozess4 { get; set; }
        public string Prozess5 { get; set; }
        public string DsSoftware { get; set; }
        public string Somwin { get; set; }
        public string FbSperre { get; set; }
        public string Autosourceswitch { get; set; }
        public string Nosignalpower { get; set; }
        public string Networkstandby { get; set; }
        public string Energysaving { get; set; }
        public string Ecosensor { get; set; }
        public string Autopoweroff { get; set; }
        public string Autopoweron { get; set; }
        public string Sound { get; set; }
        public string PlayoutFunction { get; set; }
        public string PlayoutStandard { get; set; }
        public string PlayoutFallback { get; set; }
        public string PlayoutPlayer { get; set; }
        public string PlayoutDir { get; set; }
        public string FTransfer { get; set; }
        public string FServer { get; set; }
        public string FRoot { get; set; }
        public string FUser1 { get; set; }
        public string FLocaldrive { get; set; }
        public string FDirup { get; set; }
        public string FDirdown { get; set; }
        public string FTypeup { get; set; }
        public string FTypedown { get; set; }
        public string FRepeat { get; set; }
        public string OsagTimeHandling { get; set; }
        public string OsagPlayCheck { get; set; }
        public string OsagConnLogCopy { get; set; }
        public string OsagDisplayTrace { get; set; }
        public string OsagDisplayCheck { get; set; }
        public string OsagDeName { get; set; }
        public string OsagConfigState { get; set; }
        public string OsagTime { get; set; }
        public string OsagConnLog { get; set; }
        public string OsagPlayLog { get; set; }
    }
}
