﻿using Mono.Cecil;
using Mono.Cecil.Cil;
using MonoMod.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Olympus {
    public unsafe class CmdAhornGetInfo : Cmd<CmdAhornGetInfo.Info> {

        public override Info Run() {
            return new Info();
        }

        public class Info {

            public string RootPath = AhornHelper.RootPath;

            public string JuliaPath = AhornHelper.JuliaPath;
            public bool JuliaIsLocal = AhornHelper.JuliaIsLocal;
            public string JuliaVersion = AhornHelper.GetJuliaVersion();
            public string JuliaVersionRecommended = "1.5.3"; // See CmdAhornInstallJulia

            // FIXME: Implement!
            public string AhornPath;
            public string AhornVersion;

        }

    }
}