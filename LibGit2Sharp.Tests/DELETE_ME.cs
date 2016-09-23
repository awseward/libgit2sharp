using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace LibGit2Sharp.Tests
{
    public class DELETE_ME
    {
        [Fact]
        public void DoTheThing()
        {
            var repoUrl = "https://github.com/awseward/restivus";
            var destination = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                Guid.NewGuid().ToString()
            );

            Repository.Clone(repoUrl, destination);

            Directory.Delete(destination, true);
        }
    }
}
