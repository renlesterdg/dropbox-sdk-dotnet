// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The list folder arg object</para>
    /// </summary>
    public sealed class ListFolderArg : enc.IEncodable<ListFolderArg>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderArg" /> class.</para>
        /// </summary>
        /// <param name="path">The path to the folder you want to see the contents of.</param>
        /// <param name="recursive">If true, list folder operation will be applied recursively
        /// to all subfolders. And the response will contain contents of all subfolders</param>
        public ListFolderArg(string path,
                             bool recursive = false)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            else if (!re.Regex.IsMatch(path, @"(/.*)?"))
            {
                throw new sys.ArgumentOutOfRangeException("path");
            }

            this.Path = path;
            this.Recursive = recursive;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListFolderArg()
        {
            this.Recursive = false;
        }

        /// <summary>
        /// <para>The path to the folder you want to see the contents of.</para>
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// <para>If true, list folder operation will be applied recursively to all subfolders.
        /// And the response will contain contents of all subfolders</para>
        /// </summary>
        public bool Recursive { get; private set; }

        #region IEncodable<ListFolderArg> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ListFolderArg>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("path", this.Path);
                obj.AddField<bool>("recursive", this.Recursive);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ListFolderArg enc.IEncodable<ListFolderArg>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Path = obj.GetField<string>("path");
                if (obj.HasField("recursive"))
                {
                    this.Recursive = obj.GetField<bool>("recursive");
                }
            }

            return this;
        }

        #endregion
    }
}
