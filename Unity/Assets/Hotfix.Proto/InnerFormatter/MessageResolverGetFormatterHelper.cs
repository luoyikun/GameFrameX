// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

using MessagePack.Formatters.Hotfix.Proto.Proto;
using GameFramework.Network;

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1649 // File name should match first type name

namespace Resolvers
{
    internal static class MessageResolverGetFormatterHelper
    {
        private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, int> lookup;

        static MessageResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(1)
            {
                { typeof(MessageObject), 0 },

            };
        }

        internal static object GetFormatter(global::System.Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new MessageFormatter();
              
                default: return null;
            }
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1649 // File name should match first type name
