namespace EnvVarAwareness.Test
{
    [TestClass]
    public class SimpleTest
    {
        [TestMethod]
        public void GetHomeDirectoryTest()
        {
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                var windowsEnv = new KnownWindowsEnv();
                Assert.AreEqual(Environment.GetEnvironmentVariable("USERPROFILE"), windowsEnv.UserProfile);
            }
            else
            {
                var linuxEnv = new KnownLinuxEnv();
                Assert.AreEqual(Environment.GetEnvironmentVariable("HOME"), linuxEnv.Home);
            }
        }

        [TestMethod]
        public void GetMultipleEnvsTest()
        {
            var envBase = new EnvBase();
            Assert.IsTrue(envBase.GetEnvironmentVariables().Count > 0);
        }
    }
}
