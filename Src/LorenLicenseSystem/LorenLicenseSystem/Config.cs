////////////////////////////////////////////////
//             LORENSTUDIO                     /
//          By Rodrigo(Lucifer)                /
//          Whats: (22)98186-8617              /
//        Email: suporte@lorenstudio.com       /
////////////////////////////////////////////////
using System;

namespace LorenLicenseSystem
{
    public static class Config
    {
        public static string dbName, dbHost, dbUser, dbPass, hosIp, serverIp, udpVersion, ServerVersion;
        // public static int dbPort;
        public static ushort hosPort, maxDrop, syncPort;
        public static bool sendFailMsg, useMaxAmmoInDrop, HostLogger;
        public static float plantDuration, defuseDuration;
        public static bool useHitMarker;

        public static void LoadDB()
        {
            ConfigFile configFile = new ConfigFile("config/DataBase.ini");
            dbHost = configFile.readString("dbhost", "localhost");
            dbName = configFile.readString("dbname", "");
            dbUser = configFile.readString("dbuser", "root");
            dbPass = configFile.readString("dbpass", "");
        }
    }
}