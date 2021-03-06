// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Basic information about any account.</para>
    /// </summary>
    /// <seealso cref="Account" />
    public sealed class BasicAccount : enc.IEncodable<BasicAccount>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="BasicAccount" /> class.</para>
        /// </summary>
        /// <param name="accountId">The user's unique Dropbox ID.</param>
        /// <param name="name">Details of a user's name.</param>
        /// <param name="isTeammate">Whether this user is a teammate of the current user. If
        /// this account is the current user's account, then this will be <c>true</c>.</param>
        public BasicAccount(string accountId,
                            Name name,
                            bool isTeammate)
        {
            if (accountId == null)
            {
                throw new sys.ArgumentNullException("accountId");
            }
            else if (accountId.Length < 40 || accountId.Length > 40)
            {
                throw new sys.ArgumentOutOfRangeException("accountId");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            this.AccountId = accountId;
            this.Name = name;
            this.IsTeammate = isTeammate;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="BasicAccount" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public BasicAccount()
        {
        }

        /// <summary>
        /// <para>The user's unique Dropbox ID.</para>
        /// </summary>
        public string AccountId { get; private set; }

        /// <summary>
        /// <para>Details of a user's name.</para>
        /// </summary>
        public Name Name { get; private set; }

        /// <summary>
        /// <para>Whether this user is a teammate of the current user. If this account is the
        /// current user's account, then this will be <c>true</c>.</para>
        /// </summary>
        public bool IsTeammate { get; private set; }

        #region IEncodable<BasicAccount> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<BasicAccount>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("account_id", this.AccountId);
                obj.AddFieldObject<Name>("name", this.Name);
                obj.AddField<bool>("is_teammate", this.IsTeammate);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        BasicAccount enc.IEncodable<BasicAccount>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.AccountId = obj.GetField<string>("account_id");
                this.Name = obj.GetFieldObject<Name>("name");
                this.IsTeammate = obj.GetField<bool>("is_teammate");
            }

            return this;
        }

        #endregion
    }
}
