﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace dvbseserviceview
{
    internal class DvbSTuner
    {
        int roll_off = -1;
        int modulation_type = -1;
        int modulation_system = -1;
        string fec = "";
        int symbolrate = -1;
        string polarity = "";
        int frequency = -1;
        string position = "";

        public int RollOff
        {
            get
            {
                return this.roll_off;
            }
            set
            {
                this.roll_off = value;
            }
        }
        public int ModulationType
        {
            get
            {
                return this.modulation_type;
            }
            set
            {
                this.modulation_type = value;
            }
        }
        public int ModulationSystem
        {
            get
            {
                return this.modulation_system;
            }
            set
            {
                this.modulation_system = value;
            }
        }
        public string Fec
        {
            get
            {
                return this.fec;
            }
            set
            {
                this.fec = value;
            }
        }
        public int Symbolrate
        {
            get
            {
                return this.symbolrate;
            }
            set
            {
                this.symbolrate = value;
            }
        }
        public string Polarity
        {
            get
            {
                return this.polarity;
            }
            set
            {
                this.polarity = value;
            }
        }
        public int Frequency
        {
            get
            {
                return this.frequency;
            }
            set
            {
                this.frequency = value;
            }
        }
        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }
    }

    internal class DvbCTTuner
    {
        int frequency = -1;

        public int Frequency
        {
            get
            {
                return this.frequency;
            }
            set
            {
                this.frequency = value;
            }
        }
    }

    internal class CA
    {
        int ca_pid = -1;
        int ca_system_id = -1;
        byte[] ca_private_bytes = new byte[0];

        public int Pid
        {
            get
            {
                return this.ca_pid;
            }
            set
            {
                this.ca_pid = value;
            }
        }
        public int SystemId
        {
            get
            {
                return this.ca_system_id;
            }
            set
            {
                this.ca_system_id = value;
            }
        }
        public byte[] PrivateBytes
        {
            get
            {
                return this.ca_private_bytes;
            }
            set
            {
                this.ca_private_bytes = value;
            }
        }
    }

    internal class Stream
    {
        int type = -1;
        string type2 = "";
        int pid = -1;
        List<CA> ca_list = new List<CA>();
        string application_name = "";
        string language = "";

        public int Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Type2
        {
            get
            {
                return this.type2;
            }
            set
            {
                this.type2 = value;
            }
        }
        public int Pid
        {
            get
            {
                return this.pid;
            }
            set
            {
                this.pid = value;
            }
        }
        public List<CA> CAList
        {
            get
            {
                return this.ca_list;
            }
            set
            {
                this.ca_list = value;
            }
        }
        public string ApplicationName
        {
            get
            {
                return this.application_name;
            }
            set
            {
                this.application_name = value;
            }
        }
        public string Language
        {
            get
            {
                return this.language;
            }
            set
            {
                this.language = value;
            }
        }
    }

    internal class Bouquet
    {
        int id=-1;
        string name="";

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }

    internal class Service
    {
        int number = -1; // number reflecting order in XML file
        int mux_id = -1;
        int lcn = -1;
        bool freecamode = false;
        int type = -1;
        int pcr = -1;
        int pmt = -1;
        int sid = -1;
        int tsid = -1;
        int nid = -1;
        int onid = -1;
        string network_name = "";
        string network_type = "";
        string provider = "";
        string name = "";
        List<Stream> streams = new List<Stream>();
        List<CA> ca_list = new List<CA>();
        List<Bouquet> bouquet_list = new List<Bouquet>();
        string video_pid_list="";
        string audio_pid_list = "";
        string bouquet_list_string = "";
        string ca_system_id_list = "";
        string feature_list = "";
        string position = "";

        DvbSTuner dvbstuner = new DvbSTuner();
        DvbCTTuner dvbcttuner = new DvbCTTuner();

        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }
        public DvbSTuner DvbSTuner
        {
            get
            {
                return this.dvbstuner;
            }
            set
            {
                this.dvbstuner = value;
            }
        }
        public DvbCTTuner DvbCTTuner
        {
            get
            {
                return this.dvbcttuner;
            }
            set
            {
                this.dvbcttuner = value;
            }
        }

        public int Lcn
        {
            get
            {
                return this.lcn;
            }
            set
            {
                this.lcn = value;
            }
        }
        public bool FreeCaMode
        {
            get
            {
                return this.freecamode;
            }
            set
            {
                this.freecamode = value;
            }
        }
        public int Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public int Pcr
        {
            get
            {
                return this.pcr;
            }
            set
            {
                this.pcr = value;
            }
        }
        public int Pmt
        {
            get
            {
                return this.pmt;
            }
            set
            {
                this.pmt = value;
            }
        }
        public int Sid
        {
            get
            {
                return this.sid;
            }
            set
            {
                this.sid = value;
            }
        }
        public int Tsid
        {
            get
            {
                return this.tsid;
            }
            set
            {
                this.tsid = value;
            }
        }
        public int Nid
        {
            get
            {
                return this.nid;
            }
            set
            {
                this.nid = value;
            }
        }
        public int Onid
        {
            get
            {
                return this.onid;
            }
            set
            {
                this.onid = value;
            }
        }
        public string NetworkName
        {
            get
            {
                return this.network_name;
            }
            set
            {
                this.network_name = value;
            }
        }
        public string NetworkType
        {
            get
            {
                return this.network_type;
            }
            set
            {
                this.network_type = value;
            }
        }
        public string Provider
        {
            get
            {
                return this.provider;
            }
            set
            {
                this.provider = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public List<Stream> Streams
        {
            get
            {
                return this.streams;
            }
            set
            {
                this.streams = value;
            }
        }
        public List<CA> CAList
        {
            get
            {
                return this.ca_list;
            }
            set
            {
                this.ca_list = value;
            }
        }
        public List<Bouquet> BouquetList
        {
            get
            {
                return this.bouquet_list;
            }
            set
            {
                this.bouquet_list = value;
            }
        }
        public int MuxId
        {
            get
            {
                return this.mux_id;
            }
            set
            {
                this.mux_id = value;
            }
        }
        public int No
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        public string VideoPidList
        {
            get
            {
                return this.video_pid_list;
            }
        }
        public string AudioPidList
        {
            get
            {
                return this.audio_pid_list;
            }
        }
        public string BouquetListString
        {
            get
            {
                return this.bouquet_list_string;
            }
        }
        public string CaSystemIdList
        {
            get
            {
                return this.ca_system_id_list;
            }
        }
        public string FeatureList
        {
            get
            {
                return this.feature_list;
            }
        }

        private void CreateVideoPidList()
        {
            string tmp = "";
            bool first = true;
            foreach (var stream in this.streams)
            {
                if (IsVideoStream(stream.Type2))
                {
                    if (!first)
                    {
                        tmp += ",";
                        tmp += Convert.ToString(stream.Pid);
                    }
                    else
                    {
                        tmp += Convert.ToString(stream.Pid);
                        first = false;
                    }
                }
            }
            this.video_pid_list = tmp;
        }

        private void CreateAudioPidList()
        {
            string tmp = "";
            bool first = true;
            foreach (var stream in this.streams)
            {
                if (IsaudioStream(stream.Type2))
                {
                    if (!first)
                    {
                        tmp += ",";
                        tmp += Convert.ToString(stream.Pid);
                        if (stream.Language.Count() > 0)
                        {
                            tmp += string.Format(":{0}", stream.Language);
                        }
                    }
                    else
                    {
                        tmp += Convert.ToString(stream.Pid);
                        if (stream.Language.Count() > 0)
                        {
                            tmp += string.Format(":{0}", stream.Language);
                        }
                        first = false;
                    }
                }
            }
            this.audio_pid_list = tmp;
        }

        private void CreateCaSystemIdList()
        {
            SortedSet<int> calist = new SortedSet<int>();
            foreach (var ca in this.ca_list)
            {
                calist.Add(ca.SystemId);
            }
            foreach (var stream in this.streams)
            {
                foreach (var ca in stream.CAList)
                {
                    calist.Add(ca.SystemId);
                }
            }
            string tmp = "";
            bool first = true;
            foreach (var ca in calist)
            {
                if (!first)
                {
                    tmp += ",";
                    tmp += Convert.ToString(ca);
                }
                else
                {
                    tmp += Convert.ToString(ca);
                    first = false;
                }
            }
            this.ca_system_id_list = tmp;
        }

        private void CreateBouquetList()
        {
            string tmp = "";
            bool first = true;
            foreach (var bouquet in this.bouquet_list)
            {
                if (!first)
                {
                    tmp += ",";
                    tmp += Convert.ToString(bouquet.Id);
                }
                else
                {
                    tmp += Convert.ToString(bouquet.Id);
                    first = false;
                }
            }
            this.bouquet_list_string = tmp;
        }

        private void CreateFeatureList()
        {
            SortedSet<string> list = new SortedSet<string>();
            foreach (var s in this.streams)
            {
                if (s.Type2 == "mhp" || s.Type2 == "ip" || s.Type2 == "teletext" || s.Type2 == "mhp_oc" || s.Type2 == "mpe" || s.Type2 == "subtitle" || s.Type2 == "hbbtv") list.Add(s.Type2);
            }
            string tmp = "";
            bool first = true;
            foreach (var s in list)
            {
                if (!first)
                {
                    tmp += ",";
                    tmp += s;
                }
                else
                {
                    tmp += s;
                    first = false;
                }
            }
            this.feature_list = tmp;
        }

        private bool IsVideoStream(string type)
        {
            switch (type)
            {
                case "11172-2":
                case "13818-2":
                case "14496-10":
                case "H.265":
                    return true;
                default:
                    return false;
            }
        }

        private bool IsaudioStream(string type)
        {
            switch (type)
            {
                case "11172-3":
                case "13818-3":
                case "ac3":
                case "dts":
                case "aac":
                case "14496-3":
                    return true;
                default:
                    return false;
            }
        }

        public void Update()
        {
            CreateVideoPidList();
            CreateAudioPidList();
            CreateCaSystemIdList();
            CreateBouquetList();
            CreateFeatureList();
        }
    }


    //internal class ServiceDVBS : Service
    //{
    //    int roll_off = -1;
    //    int modulation_type = -1;
    //    int modulation_system = -1;
    //    string fec = "";
    //    int symbolrate = -1;
    //    string polarity = "";
    //    int frequency = -1;
    //    string position = "";

    //    public int RollOff
    //    {
    //        get
    //        {
    //            return this.roll_off;
    //        }
    //        set
    //        {
    //            this.roll_off = value;
    //        }
    //    }
    //    public int ModulationType
    //    {
    //        get
    //        {
    //            return this.modulation_type;
    //        }
    //        set
    //        {
    //            this.modulation_type = value;
    //        }
    //    }
    //    public int ModulationSystem
    //    {
    //        get
    //        {
    //            return this.modulation_system;
    //        }
    //        set
    //        {
    //            this.modulation_system = value;
    //        }
    //    }
    //    public string Fec
    //    {
    //        get
    //        {
    //            return this.fec;
    //        }
    //        set
    //        {
    //            this.fec = value;
    //        }
    //    }
    //    public int Symbolrate
    //    {
    //        get
    //        {
    //            return this.symbolrate;
    //        }
    //        set
    //        {
    //            this.symbolrate = value;
    //        }
    //    }
    //    public string Polarity
    //    {
    //        get
    //        {
    //            return this.polarity;
    //        }
    //        set
    //        {
    //            this.polarity = value;
    //        }
    //    }
    //    public int Frequency
    //    {
    //        get
    //        {
    //            return this.frequency;
    //        }
    //        set
    //        {
    //            this.frequency = value;
    //        }
    //    }
    //    public string Position
    //    {
    //        get
    //        {
    //            return this.position;
    //        }
    //        set
    //        {
    //            this.position = value;
    //        }
    //    }
    //}

    //internal class ServiceDVBT : Service
    //{
    //    int frequency = -1;

    //    public int Frequency
    //    {
    //        get
    //        {
    //            return this.frequency;
    //        }
    //        set
    //        {
    //            this.frequency = value;
    //        }
    //    }
    //}

    //internal class ServiceDVBC : Service
    //{
    //    int frequency = -1;

    //    public int Frequency
    //    {
    //        get
    //        {
    //            return this.frequency;
    //        }
    //        set
    //        {
    //            this.frequency = value;
    //        }
    //    }
    //}
}