using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Harmony;
using System.Reflection;

public class Blank : Mod
{
    public Blank() : base("Name of Mod", "Blank", "1.0", "1.01B")
    {
        var harmony = HarmonyInstance.Create("com.raft.MODAUTHOR.MODNAME");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}