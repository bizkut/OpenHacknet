// Stub file for Steamworks types - Steam integration is disabled
using System;

namespace Steamworks
{
    public static class SteamAPI
    {
        public static bool Init() => false;
        public static bool InitSafe() => false;
    }

    public static class SteamRemoteStorage
    {
        public static bool FileExists(string pchFile) => false;
        public static int FileRead(string pchFile, byte[] pvData, int cubDataToRead) => 0;
        public static bool FileWrite(string pchFile, byte[] pvData, int cubData) => false;
        public static bool FileDelete(string pchFile) => false;
        public static int GetFileSize(string pchFile) => 0;
        public static long GetFileTimestamp(string pchFile) => 0;
        public static bool IsCloudEnabledForAccount() => false;
    }

    public static class SteamUserStats
    {
        public static bool SetStat(string pchName, int nData) => false;
        public static bool SetStat(string pchName, float fData) => false;
        public static bool StoreStats() => false;
        public static bool SetAchievement(string pchName) => false;
    }

    public struct UserStatsReceived_t
    {
        public ulong m_nGameID;
        public int m_eResult;
        public ulong m_steamIDUser;
    }

    public class Callback<T>
    {
        public static Callback<T> Create(Action<T> func) => new Callback<T>();
    }
}
