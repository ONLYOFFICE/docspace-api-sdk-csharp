/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// [1000 - Login success, 1001 - Login success via social account, 1002 - Login fail invalid combination, 1003 - Login fail social account not found, 1004 - Login fail disabled profile, 1005 - Login fail, 1006 - Logout, 1007 - Login success via sms, 1008 - Login fail via sms, 1009 - Login fail ip security, 1010 - Login success via api, 1011 - Login success via social app, 1012 - Login success via api sms, 1013 - Login fail via api, 1014 - Login fail via api sms, 1015 - Login success via SSO, 1016 - Session started, 1017 - Session completed, 1018 - Login fail via SSO, 1019 - Login success via api social account, 1020 - Login fail via api social account, 1021 - Login succes via tfa app, 1022 - Login fail via Tfa app, 1023 - Login fail brute force, 1024 - Login success via api tfa, 1025 - Login fail via api tfa, 1026 - Login fail recaptcha, 1027 - Authorization link activated, 4000 - User created, 4001 - Guest created, 4002 - User created via invite, 4003 - Guest created via invite, 4004 - User activated, 4005 - Guest activated, 4006 - User updated, 4007 - User updated language, 4008 - User added avatar, 4009 - User deleted avatar, 4010 - User updated avatar thumbnails, 4011 - User linked social account, 4012 - User unlinked social account, 4013 - User sent activation instructions, 4014 - User sent email change instructions, 4015 - User sent password change instructions, 4016 - User sent delete instructions, 4017 - User updated password, 4018 - User deleted, 4019 - Users updated type, 4020 - Users updated status, 4021 - Users sent activation instructions, 4022 - Users deleted, 4023 - Sent invite instructions, 4024 - User imported, 4025 - Guest imported, 4026 - Group created, 4027 - Group updated, 4028 - Group deleted, 4029 - User updated mobile number, 4030 - User data reassigns, 4031 - User data removing, 4032 - User connected tfa app, 4033 - User disconnected tfa app, 4034 - User logout active connections, 4035 - User logout active connection, 4036 - User logout active connections for user, 4037 - Send join invite, 5000 - File created, 5001 - File renamed, 5002 - File updated, 5003 - File created version, 5004 - File deleted version, 5005 - File updated revision comment, 5006 - File locked, 5007 - File unlocked, 5008 - File updated access, 5009 - File downloaded, 5010 - File downloaded as, 5011 - File uploaded, 5012 - File imported, 5013 - File copied, 5014 - File copied with overwriting, 5015 - File moved, 5016 - File moved with overwriting, 5017 - File moved to trash, 5018 - File deleted, 5019 - Folder created, 5020 - Folder renamed, 5021 - Folder updated access, 5022 - Folder copied, 5023 - Folder copied with overwriting, 5024 - Folder moved, 5025 - Folder moved with overwriting, 5026 - Folder moved to trash, 5027 - Folder deleted, 5028 - ThirdParty created, 5029 - ThirdParty updated, 5030 - ThirdParty deleted, 5031 - Documents ThirdParty settings updated, 5032 - Documents overwriting settings updated, 5033 - Documents uploading formats settings updated, 5034 - User file updated, 5035 - File converted, 5036 - File send access link, 5037 - Document service location setting, 5038 - Authorization keys setting, 5039 - Full text search setting, 5040 - Start transfer setting, 5041 - Start backup setting, 5042 - License key uploaded, 5043 - File change owner, 5044 - File restore version, 5045 - Document send to sign, 5046 - Document sign complete, 5047 - User updated email, 5048 - Documents store forcesave, 5049 - Documents forcesave, 5050 - Start storage encryption, 5051 - Privacy room enable, 5052 - Privacy room disable, 5053 - Start storage decryption, 5054 - File opened for change, 5055 - File marked as favorite, 5056 - File removed from favorite, 5057 - Folder downloaded, 5058 - File removed from list, 5059 - Folder removed from list, 5060 - File external link access updated, 5061 - Trash emptied, 5062 - File revision downloaded, 5063 - File marked as read, 5064 - File readed, 5065 - Folder marked as read, 5066 - Folder updated access for, 5068 - File updated access for, 5069 - Documents external share settings updated, 5070 - Room created, 5071 - Room renamed, 5072 - Room archived, 5073 - Room unarchived, 5074 - Room deleted, 5075 - Room update access for user, 5076 - Tag created, 5077 - Tags deleted, 5078 - Added room tags, 5079 - Deleted room tags, 5080 - Room logo created, 5081 - Room logo deleted, 5082 - Room invitation link updated, 5083 - Documents keep new file name settings updated, 5084 - Room remove user, 5085 - Room create user, 5086 - Room invitation link created, 5087 - Room invitation link deleted, 5088 - Room external link created, 5089 - Room external link updated, 5090 - Room external link deleted, 5091 - File external link created, 5092 - File external link updated, 5093 - File external link deleted, 5094 - Room group added, 5095 - Room update access for group, 5096 - Room group remove, 5097 - Room external link revoked, 5098 - Room external link renamed, 5099 - File uploaded with overwriting, 5100 - Room copied, 5101 - Documents display file extension updated, 5102 - Room color changed, 5103 - Room cover changed, 5104 - Room indexing changed, 5105 - Room deny download changed, 5106 - Room index export saved, 5107 - Folder index changed, 5108 - Folder index reordered, 5109 - Room deny download enabled, 5110 - Room deny download disabled, 5111 - File index changed, 5112 - Room watermark set, 5113 - Room watermark disabled, 5114 - Room index export saved, 5115 - Room indexing disabled, 5116 - Room life time set, 5117 - Room life time disabled, 5118 - Room invite resend, 5119 - File version deleted, 5120 - File custom filter enabled, 5121 - File custom filter disabled, 5150 - Form started to fill, 5151 - Form partially filled, 5152 - Form completely filled, 5153 - Form stopped, 5501 - Ldap enabled, 5502 - Ldap disabled, 5503 - LDAP synchronization completed, 6000 - Language settings updated, 6001 - Time zone settings updated, 6002 - Dns settings updated, 6003 - Trusted mail domain settings updated, 6004 - Password strength settings updated, 6005 - Two factor authentication settings updated, 6006 - Administrator message settings updated, 6007 - Default start page settings updated, 6008 - Products list updated, 6009 - Administrator added, 6010 - Administrator opened full access, 6011 - Administrator deleted, 6012 - Users opened product access, 6013 - Groups opened product access, 6014 - Product access opened, 6015 - Product access restricted, 6016 - Product added administrator, 6017 - Product deleted administrator, 6018 - Greeting settings updated, 6019 - Team template changed, 6020 - Color theme changed, 6021 - Owner sent change owner instructions, 6022 - Owner updated, 6023 - Owner sent portal deactivation instructions, 6024 - Owner sent portal delete instructions, 6025 - Portal deactivated, 6026 - Portal deleted, 6027 - Login history report downloaded, 6028 - Audit trail report downloaded, 6029 - SSO enabled, 6030 - SSO disabled, 6031 - Portal access settings updated, 6032 - Cookie settings updated, 6033 - Mail service settings updated, 6034 - Custom navigation settings updated, 6035 - Audit settings updated, 6036 - Two factor authentication disabled, 6037 - Two factor authentication enabled by sms, 6038 - Two factor authentication enabled by tfa app, 6039 - Portal renamed, 6040 - Quota per room changed, 6041 - Quota per room disabled, 6042 - Quota per user changed, 6043 - Quota per user disabled, 6044 - Quota per portal changed, 6045 - Quota per portal disabled, 6046 - Form submit, 6047 - Form opened for filling, 6048 - Custom quota per room default, 6049 - Custom quota per room changed, 6050 - Custom quota per room disabled, 6051 - Custom quota per user default, 6052 - Custom quota per user changed, 6053 - Custom quota per user disabled, 6054 - DevTools access settings changed, 6055 - Webhook created, 6056 - Webhook updated, 6057 - Webhook deleted, 6058 - Created api key, 6059 - Update api key, 6060 - Deleted User api key, 6061 - Customer wallet topped up, 6062 - Customer operation performed, 6063 - Customer operations report downloaded, 6064 - Customer wallet top up settings updated, 6065 - Customer subscription updated, 6066 - Promotional banners visibility settings changed, 7000 - Contact admin mail sent, 7001 - Room invite link used, 7002 - User created and added to room, 7003 - Guest created and added to room, 7004 - Contact sales mail sent, 9901 - Create client, 9902 - Update client, 9903 - Regenerate secret, 9904 - Delete client, 9905 - Change client activation, 9906 - Change client visibility, 9907 - Revoke user client, 9908 - Generate authorization code token, 9909 - Generate personal access token, -1 - None]
    /// </summary>
    /// <value>[1000 - Login success, 1001 - Login success via social account, 1002 - Login fail invalid combination, 1003 - Login fail social account not found, 1004 - Login fail disabled profile, 1005 - Login fail, 1006 - Logout, 1007 - Login success via sms, 1008 - Login fail via sms, 1009 - Login fail ip security, 1010 - Login success via api, 1011 - Login success via social app, 1012 - Login success via api sms, 1013 - Login fail via api, 1014 - Login fail via api sms, 1015 - Login success via SSO, 1016 - Session started, 1017 - Session completed, 1018 - Login fail via SSO, 1019 - Login success via api social account, 1020 - Login fail via api social account, 1021 - Login succes via tfa app, 1022 - Login fail via Tfa app, 1023 - Login fail brute force, 1024 - Login success via api tfa, 1025 - Login fail via api tfa, 1026 - Login fail recaptcha, 1027 - Authorization link activated, 4000 - User created, 4001 - Guest created, 4002 - User created via invite, 4003 - Guest created via invite, 4004 - User activated, 4005 - Guest activated, 4006 - User updated, 4007 - User updated language, 4008 - User added avatar, 4009 - User deleted avatar, 4010 - User updated avatar thumbnails, 4011 - User linked social account, 4012 - User unlinked social account, 4013 - User sent activation instructions, 4014 - User sent email change instructions, 4015 - User sent password change instructions, 4016 - User sent delete instructions, 4017 - User updated password, 4018 - User deleted, 4019 - Users updated type, 4020 - Users updated status, 4021 - Users sent activation instructions, 4022 - Users deleted, 4023 - Sent invite instructions, 4024 - User imported, 4025 - Guest imported, 4026 - Group created, 4027 - Group updated, 4028 - Group deleted, 4029 - User updated mobile number, 4030 - User data reassigns, 4031 - User data removing, 4032 - User connected tfa app, 4033 - User disconnected tfa app, 4034 - User logout active connections, 4035 - User logout active connection, 4036 - User logout active connections for user, 4037 - Send join invite, 5000 - File created, 5001 - File renamed, 5002 - File updated, 5003 - File created version, 5004 - File deleted version, 5005 - File updated revision comment, 5006 - File locked, 5007 - File unlocked, 5008 - File updated access, 5009 - File downloaded, 5010 - File downloaded as, 5011 - File uploaded, 5012 - File imported, 5013 - File copied, 5014 - File copied with overwriting, 5015 - File moved, 5016 - File moved with overwriting, 5017 - File moved to trash, 5018 - File deleted, 5019 - Folder created, 5020 - Folder renamed, 5021 - Folder updated access, 5022 - Folder copied, 5023 - Folder copied with overwriting, 5024 - Folder moved, 5025 - Folder moved with overwriting, 5026 - Folder moved to trash, 5027 - Folder deleted, 5028 - ThirdParty created, 5029 - ThirdParty updated, 5030 - ThirdParty deleted, 5031 - Documents ThirdParty settings updated, 5032 - Documents overwriting settings updated, 5033 - Documents uploading formats settings updated, 5034 - User file updated, 5035 - File converted, 5036 - File send access link, 5037 - Document service location setting, 5038 - Authorization keys setting, 5039 - Full text search setting, 5040 - Start transfer setting, 5041 - Start backup setting, 5042 - License key uploaded, 5043 - File change owner, 5044 - File restore version, 5045 - Document send to sign, 5046 - Document sign complete, 5047 - User updated email, 5048 - Documents store forcesave, 5049 - Documents forcesave, 5050 - Start storage encryption, 5051 - Privacy room enable, 5052 - Privacy room disable, 5053 - Start storage decryption, 5054 - File opened for change, 5055 - File marked as favorite, 5056 - File removed from favorite, 5057 - Folder downloaded, 5058 - File removed from list, 5059 - Folder removed from list, 5060 - File external link access updated, 5061 - Trash emptied, 5062 - File revision downloaded, 5063 - File marked as read, 5064 - File readed, 5065 - Folder marked as read, 5066 - Folder updated access for, 5068 - File updated access for, 5069 - Documents external share settings updated, 5070 - Room created, 5071 - Room renamed, 5072 - Room archived, 5073 - Room unarchived, 5074 - Room deleted, 5075 - Room update access for user, 5076 - Tag created, 5077 - Tags deleted, 5078 - Added room tags, 5079 - Deleted room tags, 5080 - Room logo created, 5081 - Room logo deleted, 5082 - Room invitation link updated, 5083 - Documents keep new file name settings updated, 5084 - Room remove user, 5085 - Room create user, 5086 - Room invitation link created, 5087 - Room invitation link deleted, 5088 - Room external link created, 5089 - Room external link updated, 5090 - Room external link deleted, 5091 - File external link created, 5092 - File external link updated, 5093 - File external link deleted, 5094 - Room group added, 5095 - Room update access for group, 5096 - Room group remove, 5097 - Room external link revoked, 5098 - Room external link renamed, 5099 - File uploaded with overwriting, 5100 - Room copied, 5101 - Documents display file extension updated, 5102 - Room color changed, 5103 - Room cover changed, 5104 - Room indexing changed, 5105 - Room deny download changed, 5106 - Room index export saved, 5107 - Folder index changed, 5108 - Folder index reordered, 5109 - Room deny download enabled, 5110 - Room deny download disabled, 5111 - File index changed, 5112 - Room watermark set, 5113 - Room watermark disabled, 5114 - Room index export saved, 5115 - Room indexing disabled, 5116 - Room life time set, 5117 - Room life time disabled, 5118 - Room invite resend, 5119 - File version deleted, 5120 - File custom filter enabled, 5121 - File custom filter disabled, 5150 - Form started to fill, 5151 - Form partially filled, 5152 - Form completely filled, 5153 - Form stopped, 5501 - Ldap enabled, 5502 - Ldap disabled, 5503 - LDAP synchronization completed, 6000 - Language settings updated, 6001 - Time zone settings updated, 6002 - Dns settings updated, 6003 - Trusted mail domain settings updated, 6004 - Password strength settings updated, 6005 - Two factor authentication settings updated, 6006 - Administrator message settings updated, 6007 - Default start page settings updated, 6008 - Products list updated, 6009 - Administrator added, 6010 - Administrator opened full access, 6011 - Administrator deleted, 6012 - Users opened product access, 6013 - Groups opened product access, 6014 - Product access opened, 6015 - Product access restricted, 6016 - Product added administrator, 6017 - Product deleted administrator, 6018 - Greeting settings updated, 6019 - Team template changed, 6020 - Color theme changed, 6021 - Owner sent change owner instructions, 6022 - Owner updated, 6023 - Owner sent portal deactivation instructions, 6024 - Owner sent portal delete instructions, 6025 - Portal deactivated, 6026 - Portal deleted, 6027 - Login history report downloaded, 6028 - Audit trail report downloaded, 6029 - SSO enabled, 6030 - SSO disabled, 6031 - Portal access settings updated, 6032 - Cookie settings updated, 6033 - Mail service settings updated, 6034 - Custom navigation settings updated, 6035 - Audit settings updated, 6036 - Two factor authentication disabled, 6037 - Two factor authentication enabled by sms, 6038 - Two factor authentication enabled by tfa app, 6039 - Portal renamed, 6040 - Quota per room changed, 6041 - Quota per room disabled, 6042 - Quota per user changed, 6043 - Quota per user disabled, 6044 - Quota per portal changed, 6045 - Quota per portal disabled, 6046 - Form submit, 6047 - Form opened for filling, 6048 - Custom quota per room default, 6049 - Custom quota per room changed, 6050 - Custom quota per room disabled, 6051 - Custom quota per user default, 6052 - Custom quota per user changed, 6053 - Custom quota per user disabled, 6054 - DevTools access settings changed, 6055 - Webhook created, 6056 - Webhook updated, 6057 - Webhook deleted, 6058 - Created api key, 6059 - Update api key, 6060 - Deleted User api key, 6061 - Customer wallet topped up, 6062 - Customer operation performed, 6063 - Customer operations report downloaded, 6064 - Customer wallet top up settings updated, 6065 - Customer subscription updated, 6066 - Promotional banners visibility settings changed, 7000 - Contact admin mail sent, 7001 - Room invite link used, 7002 - User created and added to room, 7003 - Guest created and added to room, 7004 - Contact sales mail sent, 9901 - Create client, 9902 - Update client, 9903 - Regenerate secret, 9904 - Delete client, 9905 - Change client activation, 9906 - Change client visibility, 9907 - Revoke user client, 9908 - Generate authorization code token, 9909 - Generate personal access token, -1 - None]</value>
    public enum MessageAction
    {
        /// <summary>
        /// Enum LoginSuccess for value: 1000
        /// </summary>
        LoginSuccess = 1000,

        /// <summary>
        /// Enum LoginSuccessViaSocialAccount for value: 1001
        /// </summary>
        LoginSuccessViaSocialAccount = 1001,

        /// <summary>
        /// Enum LoginFailInvalidCombination for value: 1002
        /// </summary>
        LoginFailInvalidCombination = 1002,

        /// <summary>
        /// Enum LoginFailSocialAccountNotFound for value: 1003
        /// </summary>
        LoginFailSocialAccountNotFound = 1003,

        /// <summary>
        /// Enum LoginFailDisabledProfile for value: 1004
        /// </summary>
        LoginFailDisabledProfile = 1004,

        /// <summary>
        /// Enum LoginFail for value: 1005
        /// </summary>
        LoginFail = 1005,

        /// <summary>
        /// Enum Logout for value: 1006
        /// </summary>
        Logout = 1006,

        /// <summary>
        /// Enum LoginSuccessViaSms for value: 1007
        /// </summary>
        LoginSuccessViaSms = 1007,

        /// <summary>
        /// Enum LoginFailViaSms for value: 1008
        /// </summary>
        LoginFailViaSms = 1008,

        /// <summary>
        /// Enum LoginFailIpSecurity for value: 1009
        /// </summary>
        LoginFailIpSecurity = 1009,

        /// <summary>
        /// Enum LoginSuccessViaApi for value: 1010
        /// </summary>
        LoginSuccessViaApi = 1010,

        /// <summary>
        /// Enum LoginSuccessViaSocialApp for value: 1011
        /// </summary>
        LoginSuccessViaSocialApp = 1011,

        /// <summary>
        /// Enum LoginSuccessViaApiSms for value: 1012
        /// </summary>
        LoginSuccessViaApiSms = 1012,

        /// <summary>
        /// Enum LoginFailViaApi for value: 1013
        /// </summary>
        LoginFailViaApi = 1013,

        /// <summary>
        /// Enum LoginFailViaApiSms for value: 1014
        /// </summary>
        LoginFailViaApiSms = 1014,

        /// <summary>
        /// Enum LoginSuccessViaSSO for value: 1015
        /// </summary>
        LoginSuccessViaSSO = 1015,

        /// <summary>
        /// Enum SessionStarted for value: 1016
        /// </summary>
        SessionStarted = 1016,

        /// <summary>
        /// Enum SessionCompleted for value: 1017
        /// </summary>
        SessionCompleted = 1017,

        /// <summary>
        /// Enum LoginFailViaSSO for value: 1018
        /// </summary>
        LoginFailViaSSO = 1018,

        /// <summary>
        /// Enum LoginSuccessViaApiSocialAccount for value: 1019
        /// </summary>
        LoginSuccessViaApiSocialAccount = 1019,

        /// <summary>
        /// Enum LoginFailViaApiSocialAccount for value: 1020
        /// </summary>
        LoginFailViaApiSocialAccount = 1020,

        /// <summary>
        /// Enum LoginSuccesViaTfaApp for value: 1021
        /// </summary>
        LoginSuccesViaTfaApp = 1021,

        /// <summary>
        /// Enum LoginFailViaTfaApp for value: 1022
        /// </summary>
        LoginFailViaTfaApp = 1022,

        /// <summary>
        /// Enum LoginFailBruteForce for value: 1023
        /// </summary>
        LoginFailBruteForce = 1023,

        /// <summary>
        /// Enum LoginSuccessViaApiTfa for value: 1024
        /// </summary>
        LoginSuccessViaApiTfa = 1024,

        /// <summary>
        /// Enum LoginFailViaApiTfa for value: 1025
        /// </summary>
        LoginFailViaApiTfa = 1025,

        /// <summary>
        /// Enum LoginFailRecaptcha for value: 1026
        /// </summary>
        LoginFailRecaptcha = 1026,

        /// <summary>
        /// Enum AuthLinkActivated for value: 1027
        /// </summary>
        AuthLinkActivated = 1027,

        /// <summary>
        /// Enum UserCreated for value: 4000
        /// </summary>
        UserCreated = 4000,

        /// <summary>
        /// Enum GuestCreated for value: 4001
        /// </summary>
        GuestCreated = 4001,

        /// <summary>
        /// Enum UserCreatedViaInvite for value: 4002
        /// </summary>
        UserCreatedViaInvite = 4002,

        /// <summary>
        /// Enum GuestCreatedViaInvite for value: 4003
        /// </summary>
        GuestCreatedViaInvite = 4003,

        /// <summary>
        /// Enum UserActivated for value: 4004
        /// </summary>
        UserActivated = 4004,

        /// <summary>
        /// Enum GuestActivated for value: 4005
        /// </summary>
        GuestActivated = 4005,

        /// <summary>
        /// Enum UserUpdated for value: 4006
        /// </summary>
        UserUpdated = 4006,

        /// <summary>
        /// Enum UserUpdatedLanguage for value: 4007
        /// </summary>
        UserUpdatedLanguage = 4007,

        /// <summary>
        /// Enum UserAddedAvatar for value: 4008
        /// </summary>
        UserAddedAvatar = 4008,

        /// <summary>
        /// Enum UserDeletedAvatar for value: 4009
        /// </summary>
        UserDeletedAvatar = 4009,

        /// <summary>
        /// Enum UserUpdatedAvatarThumbnails for value: 4010
        /// </summary>
        UserUpdatedAvatarThumbnails = 4010,

        /// <summary>
        /// Enum UserLinkedSocialAccount for value: 4011
        /// </summary>
        UserLinkedSocialAccount = 4011,

        /// <summary>
        /// Enum UserUnlinkedSocialAccount for value: 4012
        /// </summary>
        UserUnlinkedSocialAccount = 4012,

        /// <summary>
        /// Enum UserSentActivationInstructions for value: 4013
        /// </summary>
        UserSentActivationInstructions = 4013,

        /// <summary>
        /// Enum UserSentEmailChangeInstructions for value: 4014
        /// </summary>
        UserSentEmailChangeInstructions = 4014,

        /// <summary>
        /// Enum UserSentPasswordChangeInstructions for value: 4015
        /// </summary>
        UserSentPasswordChangeInstructions = 4015,

        /// <summary>
        /// Enum UserSentDeleteInstructions for value: 4016
        /// </summary>
        UserSentDeleteInstructions = 4016,

        /// <summary>
        /// Enum UserUpdatedPassword for value: 4017
        /// </summary>
        UserUpdatedPassword = 4017,

        /// <summary>
        /// Enum UserDeleted for value: 4018
        /// </summary>
        UserDeleted = 4018,

        /// <summary>
        /// Enum UsersUpdatedType for value: 4019
        /// </summary>
        UsersUpdatedType = 4019,

        /// <summary>
        /// Enum UsersUpdatedStatus for value: 4020
        /// </summary>
        UsersUpdatedStatus = 4020,

        /// <summary>
        /// Enum UsersSentActivationInstructions for value: 4021
        /// </summary>
        UsersSentActivationInstructions = 4021,

        /// <summary>
        /// Enum UsersDeleted for value: 4022
        /// </summary>
        UsersDeleted = 4022,

        /// <summary>
        /// Enum SentInviteInstructions for value: 4023
        /// </summary>
        SentInviteInstructions = 4023,

        /// <summary>
        /// Enum UserImported for value: 4024
        /// </summary>
        UserImported = 4024,

        /// <summary>
        /// Enum GuestImported for value: 4025
        /// </summary>
        GuestImported = 4025,

        /// <summary>
        /// Enum GroupCreated for value: 4026
        /// </summary>
        GroupCreated = 4026,

        /// <summary>
        /// Enum GroupUpdated for value: 4027
        /// </summary>
        GroupUpdated = 4027,

        /// <summary>
        /// Enum GroupDeleted for value: 4028
        /// </summary>
        GroupDeleted = 4028,

        /// <summary>
        /// Enum UserUpdatedMobileNumber for value: 4029
        /// </summary>
        UserUpdatedMobileNumber = 4029,

        /// <summary>
        /// Enum UserDataReassigns for value: 4030
        /// </summary>
        UserDataReassigns = 4030,

        /// <summary>
        /// Enum UserDataRemoving for value: 4031
        /// </summary>
        UserDataRemoving = 4031,

        /// <summary>
        /// Enum UserConnectedTfaApp for value: 4032
        /// </summary>
        UserConnectedTfaApp = 4032,

        /// <summary>
        /// Enum UserDisconnectedTfaApp for value: 4033
        /// </summary>
        UserDisconnectedTfaApp = 4033,

        /// <summary>
        /// Enum UserLogoutActiveConnections for value: 4034
        /// </summary>
        UserLogoutActiveConnections = 4034,

        /// <summary>
        /// Enum UserLogoutActiveConnection for value: 4035
        /// </summary>
        UserLogoutActiveConnection = 4035,

        /// <summary>
        /// Enum UserLogoutActiveConnectionsForUser for value: 4036
        /// </summary>
        UserLogoutActiveConnectionsForUser = 4036,

        /// <summary>
        /// Enum SendJoinInvite for value: 4037
        /// </summary>
        SendJoinInvite = 4037,

        /// <summary>
        /// Enum FileCreated for value: 5000
        /// </summary>
        FileCreated = 5000,

        /// <summary>
        /// Enum FileRenamed for value: 5001
        /// </summary>
        FileRenamed = 5001,

        /// <summary>
        /// Enum FileUpdated for value: 5002
        /// </summary>
        FileUpdated = 5002,

        /// <summary>
        /// Enum FileCreatedVersion for value: 5003
        /// </summary>
        FileCreatedVersion = 5003,

        /// <summary>
        /// Enum FileDeletedVersion for value: 5004
        /// </summary>
        FileDeletedVersion = 5004,

        /// <summary>
        /// Enum FileUpdatedRevisionComment for value: 5005
        /// </summary>
        FileUpdatedRevisionComment = 5005,

        /// <summary>
        /// Enum FileLocked for value: 5006
        /// </summary>
        FileLocked = 5006,

        /// <summary>
        /// Enum FileUnlocked for value: 5007
        /// </summary>
        FileUnlocked = 5007,

        /// <summary>
        /// Enum FileUpdatedAccess for value: 5008
        /// </summary>
        FileUpdatedAccess = 5008,

        /// <summary>
        /// Enum FileDownloaded for value: 5009
        /// </summary>
        FileDownloaded = 5009,

        /// <summary>
        /// Enum FileDownloadedAs for value: 5010
        /// </summary>
        FileDownloadedAs = 5010,

        /// <summary>
        /// Enum FileUploaded for value: 5011
        /// </summary>
        FileUploaded = 5011,

        /// <summary>
        /// Enum FileImported for value: 5012
        /// </summary>
        FileImported = 5012,

        /// <summary>
        /// Enum FileCopied for value: 5013
        /// </summary>
        FileCopied = 5013,

        /// <summary>
        /// Enum FileCopiedWithOverwriting for value: 5014
        /// </summary>
        FileCopiedWithOverwriting = 5014,

        /// <summary>
        /// Enum FileMoved for value: 5015
        /// </summary>
        FileMoved = 5015,

        /// <summary>
        /// Enum FileMovedWithOverwriting for value: 5016
        /// </summary>
        FileMovedWithOverwriting = 5016,

        /// <summary>
        /// Enum FileMovedToTrash for value: 5017
        /// </summary>
        FileMovedToTrash = 5017,

        /// <summary>
        /// Enum FileDeleted for value: 5018
        /// </summary>
        FileDeleted = 5018,

        /// <summary>
        /// Enum FolderCreated for value: 5019
        /// </summary>
        FolderCreated = 5019,

        /// <summary>
        /// Enum FolderRenamed for value: 5020
        /// </summary>
        FolderRenamed = 5020,

        /// <summary>
        /// Enum FolderUpdatedAccess for value: 5021
        /// </summary>
        FolderUpdatedAccess = 5021,

        /// <summary>
        /// Enum FolderCopied for value: 5022
        /// </summary>
        FolderCopied = 5022,

        /// <summary>
        /// Enum FolderCopiedWithOverwriting for value: 5023
        /// </summary>
        FolderCopiedWithOverwriting = 5023,

        /// <summary>
        /// Enum FolderMoved for value: 5024
        /// </summary>
        FolderMoved = 5024,

        /// <summary>
        /// Enum FolderMovedWithOverwriting for value: 5025
        /// </summary>
        FolderMovedWithOverwriting = 5025,

        /// <summary>
        /// Enum FolderMovedToTrash for value: 5026
        /// </summary>
        FolderMovedToTrash = 5026,

        /// <summary>
        /// Enum FolderDeleted for value: 5027
        /// </summary>
        FolderDeleted = 5027,

        /// <summary>
        /// Enum ThirdPartyCreated for value: 5028
        /// </summary>
        ThirdPartyCreated = 5028,

        /// <summary>
        /// Enum ThirdPartyUpdated for value: 5029
        /// </summary>
        ThirdPartyUpdated = 5029,

        /// <summary>
        /// Enum ThirdPartyDeleted for value: 5030
        /// </summary>
        ThirdPartyDeleted = 5030,

        /// <summary>
        /// Enum DocumentsThirdPartySettingsUpdated for value: 5031
        /// </summary>
        DocumentsThirdPartySettingsUpdated = 5031,

        /// <summary>
        /// Enum DocumentsOverwritingSettingsUpdated for value: 5032
        /// </summary>
        DocumentsOverwritingSettingsUpdated = 5032,

        /// <summary>
        /// Enum DocumentsUploadingFormatsSettingsUpdated for value: 5033
        /// </summary>
        DocumentsUploadingFormatsSettingsUpdated = 5033,

        /// <summary>
        /// Enum UserFileUpdated for value: 5034
        /// </summary>
        UserFileUpdated = 5034,

        /// <summary>
        /// Enum FileConverted for value: 5035
        /// </summary>
        FileConverted = 5035,

        /// <summary>
        /// Enum FileSendAccessLink for value: 5036
        /// </summary>
        FileSendAccessLink = 5036,

        /// <summary>
        /// Enum DocumentServiceLocationSetting for value: 5037
        /// </summary>
        DocumentServiceLocationSetting = 5037,

        /// <summary>
        /// Enum AuthorizationKeysSetting for value: 5038
        /// </summary>
        AuthorizationKeysSetting = 5038,

        /// <summary>
        /// Enum FullTextSearchSetting for value: 5039
        /// </summary>
        FullTextSearchSetting = 5039,

        /// <summary>
        /// Enum StartTransferSetting for value: 5040
        /// </summary>
        StartTransferSetting = 5040,

        /// <summary>
        /// Enum StartBackupSetting for value: 5041
        /// </summary>
        StartBackupSetting = 5041,

        /// <summary>
        /// Enum LicenseKeyUploaded for value: 5042
        /// </summary>
        LicenseKeyUploaded = 5042,

        /// <summary>
        /// Enum FileChangeOwner for value: 5043
        /// </summary>
        FileChangeOwner = 5043,

        /// <summary>
        /// Enum FileRestoreVersion for value: 5044
        /// </summary>
        FileRestoreVersion = 5044,

        /// <summary>
        /// Enum DocumentSendToSign for value: 5045
        /// </summary>
        DocumentSendToSign = 5045,

        /// <summary>
        /// Enum DocumentSignComplete for value: 5046
        /// </summary>
        DocumentSignComplete = 5046,

        /// <summary>
        /// Enum UserUpdatedEmail for value: 5047
        /// </summary>
        UserUpdatedEmail = 5047,

        /// <summary>
        /// Enum DocumentsStoreForcesave for value: 5048
        /// </summary>
        DocumentsStoreForcesave = 5048,

        /// <summary>
        /// Enum DocumentsForcesave for value: 5049
        /// </summary>
        DocumentsForcesave = 5049,

        /// <summary>
        /// Enum StartStorageEncryption for value: 5050
        /// </summary>
        StartStorageEncryption = 5050,

        /// <summary>
        /// Enum PrivacyRoomEnable for value: 5051
        /// </summary>
        PrivacyRoomEnable = 5051,

        /// <summary>
        /// Enum PrivacyRoomDisable for value: 5052
        /// </summary>
        PrivacyRoomDisable = 5052,

        /// <summary>
        /// Enum StartStorageDecryption for value: 5053
        /// </summary>
        StartStorageDecryption = 5053,

        /// <summary>
        /// Enum FileOpenedForChange for value: 5054
        /// </summary>
        FileOpenedForChange = 5054,

        /// <summary>
        /// Enum FileMarkedAsFavorite for value: 5055
        /// </summary>
        FileMarkedAsFavorite = 5055,

        /// <summary>
        /// Enum FileRemovedFromFavorite for value: 5056
        /// </summary>
        FileRemovedFromFavorite = 5056,

        /// <summary>
        /// Enum FolderDownloaded for value: 5057
        /// </summary>
        FolderDownloaded = 5057,

        /// <summary>
        /// Enum FileRemovedFromList for value: 5058
        /// </summary>
        FileRemovedFromList = 5058,

        /// <summary>
        /// Enum FolderRemovedFromList for value: 5059
        /// </summary>
        FolderRemovedFromList = 5059,

        /// <summary>
        /// Enum FileExternalLinkAccessUpdated for value: 5060
        /// </summary>
        FileExternalLinkAccessUpdated = 5060,

        /// <summary>
        /// Enum TrashEmptied for value: 5061
        /// </summary>
        TrashEmptied = 5061,

        /// <summary>
        /// Enum FileRevisionDownloaded for value: 5062
        /// </summary>
        FileRevisionDownloaded = 5062,

        /// <summary>
        /// Enum FileMarkedAsRead for value: 5063
        /// </summary>
        FileMarkedAsRead = 5063,

        /// <summary>
        /// Enum FileReaded for value: 5064
        /// </summary>
        FileReaded = 5064,

        /// <summary>
        /// Enum FolderMarkedAsRead for value: 5065
        /// </summary>
        FolderMarkedAsRead = 5065,

        /// <summary>
        /// Enum FolderUpdatedAccessFor for value: 5066
        /// </summary>
        FolderUpdatedAccessFor = 5066,

        /// <summary>
        /// Enum FileUpdatedAccessFor for value: 5068
        /// </summary>
        FileUpdatedAccessFor = 5068,

        /// <summary>
        /// Enum DocumentsExternalShareSettingsUpdated for value: 5069
        /// </summary>
        DocumentsExternalShareSettingsUpdated = 5069,

        /// <summary>
        /// Enum RoomCreated for value: 5070
        /// </summary>
        RoomCreated = 5070,

        /// <summary>
        /// Enum RoomRenamed for value: 5071
        /// </summary>
        RoomRenamed = 5071,

        /// <summary>
        /// Enum RoomArchived for value: 5072
        /// </summary>
        RoomArchived = 5072,

        /// <summary>
        /// Enum RoomUnarchived for value: 5073
        /// </summary>
        RoomUnarchived = 5073,

        /// <summary>
        /// Enum RoomDeleted for value: 5074
        /// </summary>
        RoomDeleted = 5074,

        /// <summary>
        /// Enum RoomUpdateAccessForUser for value: 5075
        /// </summary>
        RoomUpdateAccessForUser = 5075,

        /// <summary>
        /// Enum TagCreated for value: 5076
        /// </summary>
        TagCreated = 5076,

        /// <summary>
        /// Enum TagsDeleted for value: 5077
        /// </summary>
        TagsDeleted = 5077,

        /// <summary>
        /// Enum AddedRoomTags for value: 5078
        /// </summary>
        AddedRoomTags = 5078,

        /// <summary>
        /// Enum DeletedRoomTags for value: 5079
        /// </summary>
        DeletedRoomTags = 5079,

        /// <summary>
        /// Enum RoomLogoCreated for value: 5080
        /// </summary>
        RoomLogoCreated = 5080,

        /// <summary>
        /// Enum RoomLogoDeleted for value: 5081
        /// </summary>
        RoomLogoDeleted = 5081,

        /// <summary>
        /// Enum RoomInvitationLinkUpdated for value: 5082
        /// </summary>
        RoomInvitationLinkUpdated = 5082,

        /// <summary>
        /// Enum DocumentsKeepNewFileNameSettingsUpdated for value: 5083
        /// </summary>
        DocumentsKeepNewFileNameSettingsUpdated = 5083,

        /// <summary>
        /// Enum RoomRemoveUser for value: 5084
        /// </summary>
        RoomRemoveUser = 5084,

        /// <summary>
        /// Enum RoomCreateUser for value: 5085
        /// </summary>
        RoomCreateUser = 5085,

        /// <summary>
        /// Enum RoomInvitationLinkCreated for value: 5086
        /// </summary>
        RoomInvitationLinkCreated = 5086,

        /// <summary>
        /// Enum RoomInvitationLinkDeleted for value: 5087
        /// </summary>
        RoomInvitationLinkDeleted = 5087,

        /// <summary>
        /// Enum RoomExternalLinkCreated for value: 5088
        /// </summary>
        RoomExternalLinkCreated = 5088,

        /// <summary>
        /// Enum RoomExternalLinkUpdated for value: 5089
        /// </summary>
        RoomExternalLinkUpdated = 5089,

        /// <summary>
        /// Enum RoomExternalLinkDeleted for value: 5090
        /// </summary>
        RoomExternalLinkDeleted = 5090,

        /// <summary>
        /// Enum FileExternalLinkCreated for value: 5091
        /// </summary>
        FileExternalLinkCreated = 5091,

        /// <summary>
        /// Enum FileExternalLinkUpdated for value: 5092
        /// </summary>
        FileExternalLinkUpdated = 5092,

        /// <summary>
        /// Enum FileExternalLinkDeleted for value: 5093
        /// </summary>
        FileExternalLinkDeleted = 5093,

        /// <summary>
        /// Enum RoomGroupAdded for value: 5094
        /// </summary>
        RoomGroupAdded = 5094,

        /// <summary>
        /// Enum RoomUpdateAccessForGroup for value: 5095
        /// </summary>
        RoomUpdateAccessForGroup = 5095,

        /// <summary>
        /// Enum RoomGroupRemove for value: 5096
        /// </summary>
        RoomGroupRemove = 5096,

        /// <summary>
        /// Enum RoomExternalLinkRevoked for value: 5097
        /// </summary>
        RoomExternalLinkRevoked = 5097,

        /// <summary>
        /// Enum RoomExternalLinkRenamed for value: 5098
        /// </summary>
        RoomExternalLinkRenamed = 5098,

        /// <summary>
        /// Enum FileUploadedWithOverwriting for value: 5099
        /// </summary>
        FileUploadedWithOverwriting = 5099,

        /// <summary>
        /// Enum RoomCopied for value: 5100
        /// </summary>
        RoomCopied = 5100,

        /// <summary>
        /// Enum DocumentsDisplayFileExtensionUpdated for value: 5101
        /// </summary>
        DocumentsDisplayFileExtensionUpdated = 5101,

        /// <summary>
        /// Enum RoomColorChanged for value: 5102
        /// </summary>
        RoomColorChanged = 5102,

        /// <summary>
        /// Enum RoomCoverChanged for value: 5103
        /// </summary>
        RoomCoverChanged = 5103,

        /// <summary>
        /// Enum RoomIndexingChanged for value: 5104
        /// </summary>
        RoomIndexingChanged = 5104,

        /// <summary>
        /// Enum RoomDenyDownloadChanged for value: 5105
        /// </summary>
        RoomDenyDownloadChanged = 5105,

        /// <summary>
        /// Enum RoomIndexExportSaved for value: 5106
        /// </summary>
        RoomIndexExportSaved = 5106,

        /// <summary>
        /// Enum FolderIndexChanged for value: 5107
        /// </summary>
        FolderIndexChanged = 5107,

        /// <summary>
        /// Enum FolderIndexReordered for value: 5108
        /// </summary>
        FolderIndexReordered = 5108,

        /// <summary>
        /// Enum RoomDenyDownloadEnabled for value: 5109
        /// </summary>
        RoomDenyDownloadEnabled = 5109,

        /// <summary>
        /// Enum RoomDenyDownloadDisabled for value: 5110
        /// </summary>
        RoomDenyDownloadDisabled = 5110,

        /// <summary>
        /// Enum FileIndexChanged for value: 5111
        /// </summary>
        FileIndexChanged = 5111,

        /// <summary>
        /// Enum RoomWatermarkSet for value: 5112
        /// </summary>
        RoomWatermarkSet = 5112,

        /// <summary>
        /// Enum RoomWatermarkDisabled for value: 5113
        /// </summary>
        RoomWatermarkDisabled = 5113,

        /// <summary>
        /// Enum RoomIndexingEnabled for value: 5114
        /// </summary>
        RoomIndexingEnabled = 5114,

        /// <summary>
        /// Enum RoomIndexingDisabled for value: 5115
        /// </summary>
        RoomIndexingDisabled = 5115,

        /// <summary>
        /// Enum RoomLifeTimeSet for value: 5116
        /// </summary>
        RoomLifeTimeSet = 5116,

        /// <summary>
        /// Enum RoomLifeTimeDisabled for value: 5117
        /// </summary>
        RoomLifeTimeDisabled = 5117,

        /// <summary>
        /// Enum RoomInviteResend for value: 5118
        /// </summary>
        RoomInviteResend = 5118,

        /// <summary>
        /// Enum FileVersionRemoved for value: 5119
        /// </summary>
        FileVersionRemoved = 5119,

        /// <summary>
        /// Enum FileCustomFilterEnabled for value: 5120
        /// </summary>
        FileCustomFilterEnabled = 5120,

        /// <summary>
        /// Enum FileCustomFilterDisabled for value: 5121
        /// </summary>
        FileCustomFilterDisabled = 5121,

        /// <summary>
        /// Enum FormStartedToFill for value: 5150
        /// </summary>
        FormStartedToFill = 5150,

        /// <summary>
        /// Enum FormPartiallyFilled for value: 5151
        /// </summary>
        FormPartiallyFilled = 5151,

        /// <summary>
        /// Enum FormCompletelyFilled for value: 5152
        /// </summary>
        FormCompletelyFilled = 5152,

        /// <summary>
        /// Enum FormStopped for value: 5153
        /// </summary>
        FormStopped = 5153,

        /// <summary>
        /// Enum LdapEnabled for value: 5501
        /// </summary>
        LdapEnabled = 5501,

        /// <summary>
        /// Enum LdapDisabled for value: 5502
        /// </summary>
        LdapDisabled = 5502,

        /// <summary>
        /// Enum LdapSync for value: 5503
        /// </summary>
        LdapSync = 5503,

        /// <summary>
        /// Enum LanguageSettingsUpdated for value: 6000
        /// </summary>
        LanguageSettingsUpdated = 6000,

        /// <summary>
        /// Enum TimeZoneSettingsUpdated for value: 6001
        /// </summary>
        TimeZoneSettingsUpdated = 6001,

        /// <summary>
        /// Enum DnsSettingsUpdated for value: 6002
        /// </summary>
        DnsSettingsUpdated = 6002,

        /// <summary>
        /// Enum TrustedMailDomainSettingsUpdated for value: 6003
        /// </summary>
        TrustedMailDomainSettingsUpdated = 6003,

        /// <summary>
        /// Enum PasswordStrengthSettingsUpdated for value: 6004
        /// </summary>
        PasswordStrengthSettingsUpdated = 6004,

        /// <summary>
        /// Enum TwoFactorAuthenticationSettingsUpdated for value: 6005
        /// </summary>
        TwoFactorAuthenticationSettingsUpdated = 6005,

        /// <summary>
        /// Enum AdministratorMessageSettingsUpdated for value: 6006
        /// </summary>
        AdministratorMessageSettingsUpdated = 6006,

        /// <summary>
        /// Enum DefaultStartPageSettingsUpdated for value: 6007
        /// </summary>
        DefaultStartPageSettingsUpdated = 6007,

        /// <summary>
        /// Enum ProductsListUpdated for value: 6008
        /// </summary>
        ProductsListUpdated = 6008,

        /// <summary>
        /// Enum AdministratorAdded for value: 6009
        /// </summary>
        AdministratorAdded = 6009,

        /// <summary>
        /// Enum AdministratorOpenedFullAccess for value: 6010
        /// </summary>
        AdministratorOpenedFullAccess = 6010,

        /// <summary>
        /// Enum AdministratorDeleted for value: 6011
        /// </summary>
        AdministratorDeleted = 6011,

        /// <summary>
        /// Enum UsersOpenedProductAccess for value: 6012
        /// </summary>
        UsersOpenedProductAccess = 6012,

        /// <summary>
        /// Enum GroupsOpenedProductAccess for value: 6013
        /// </summary>
        GroupsOpenedProductAccess = 6013,

        /// <summary>
        /// Enum ProductAccessOpened for value: 6014
        /// </summary>
        ProductAccessOpened = 6014,

        /// <summary>
        /// Enum ProductAccessRestricted for value: 6015
        /// </summary>
        ProductAccessRestricted = 6015,

        /// <summary>
        /// Enum ProductAddedAdministrator for value: 6016
        /// </summary>
        ProductAddedAdministrator = 6016,

        /// <summary>
        /// Enum ProductDeletedAdministrator for value: 6017
        /// </summary>
        ProductDeletedAdministrator = 6017,

        /// <summary>
        /// Enum GreetingSettingsUpdated for value: 6018
        /// </summary>
        GreetingSettingsUpdated = 6018,

        /// <summary>
        /// Enum TeamTemplateChanged for value: 6019
        /// </summary>
        TeamTemplateChanged = 6019,

        /// <summary>
        /// Enum ColorThemeChanged for value: 6020
        /// </summary>
        ColorThemeChanged = 6020,

        /// <summary>
        /// Enum OwnerSentChangeOwnerInstructions for value: 6021
        /// </summary>
        OwnerSentChangeOwnerInstructions = 6021,

        /// <summary>
        /// Enum OwnerUpdated for value: 6022
        /// </summary>
        OwnerUpdated = 6022,

        /// <summary>
        /// Enum OwnerSentPortalDeactivationInstructions for value: 6023
        /// </summary>
        OwnerSentPortalDeactivationInstructions = 6023,

        /// <summary>
        /// Enum OwnerSentPortalDeleteInstructions for value: 6024
        /// </summary>
        OwnerSentPortalDeleteInstructions = 6024,

        /// <summary>
        /// Enum PortalDeactivated for value: 6025
        /// </summary>
        PortalDeactivated = 6025,

        /// <summary>
        /// Enum PortalDeleted for value: 6026
        /// </summary>
        PortalDeleted = 6026,

        /// <summary>
        /// Enum LoginHistoryReportDownloaded for value: 6027
        /// </summary>
        LoginHistoryReportDownloaded = 6027,

        /// <summary>
        /// Enum AuditTrailReportDownloaded for value: 6028
        /// </summary>
        AuditTrailReportDownloaded = 6028,

        /// <summary>
        /// Enum SSOEnabled for value: 6029
        /// </summary>
        SSOEnabled = 6029,

        /// <summary>
        /// Enum SSODisabled for value: 6030
        /// </summary>
        SSODisabled = 6030,

        /// <summary>
        /// Enum PortalAccessSettingsUpdated for value: 6031
        /// </summary>
        PortalAccessSettingsUpdated = 6031,

        /// <summary>
        /// Enum CookieSettingsUpdated for value: 6032
        /// </summary>
        CookieSettingsUpdated = 6032,

        /// <summary>
        /// Enum MailServiceSettingsUpdated for value: 6033
        /// </summary>
        MailServiceSettingsUpdated = 6033,

        /// <summary>
        /// Enum CustomNavigationSettingsUpdated for value: 6034
        /// </summary>
        CustomNavigationSettingsUpdated = 6034,

        /// <summary>
        /// Enum AuditSettingsUpdated for value: 6035
        /// </summary>
        AuditSettingsUpdated = 6035,

        /// <summary>
        /// Enum TwoFactorAuthenticationDisabled for value: 6036
        /// </summary>
        TwoFactorAuthenticationDisabled = 6036,

        /// <summary>
        /// Enum TwoFactorAuthenticationEnabledBySms for value: 6037
        /// </summary>
        TwoFactorAuthenticationEnabledBySms = 6037,

        /// <summary>
        /// Enum TwoFactorAuthenticationEnabledByTfaApp for value: 6038
        /// </summary>
        TwoFactorAuthenticationEnabledByTfaApp = 6038,

        /// <summary>
        /// Enum PortalRenamed for value: 6039
        /// </summary>
        PortalRenamed = 6039,

        /// <summary>
        /// Enum QuotaPerRoomChanged for value: 6040
        /// </summary>
        QuotaPerRoomChanged = 6040,

        /// <summary>
        /// Enum QuotaPerRoomDisabled for value: 6041
        /// </summary>
        QuotaPerRoomDisabled = 6041,

        /// <summary>
        /// Enum QuotaPerUserChanged for value: 6042
        /// </summary>
        QuotaPerUserChanged = 6042,

        /// <summary>
        /// Enum QuotaPerUserDisabled for value: 6043
        /// </summary>
        QuotaPerUserDisabled = 6043,

        /// <summary>
        /// Enum QuotaPerPortalChanged for value: 6044
        /// </summary>
        QuotaPerPortalChanged = 6044,

        /// <summary>
        /// Enum QuotaPerPortalDisabled for value: 6045
        /// </summary>
        QuotaPerPortalDisabled = 6045,

        /// <summary>
        /// Enum FormSubmit for value: 6046
        /// </summary>
        FormSubmit = 6046,

        /// <summary>
        /// Enum FormOpenedForFilling for value: 6047
        /// </summary>
        FormOpenedForFilling = 6047,

        /// <summary>
        /// Enum CustomQuotaPerRoomDefault for value: 6048
        /// </summary>
        CustomQuotaPerRoomDefault = 6048,

        /// <summary>
        /// Enum CustomQuotaPerRoomChanged for value: 6049
        /// </summary>
        CustomQuotaPerRoomChanged = 6049,

        /// <summary>
        /// Enum CustomQuotaPerRoomDisabled for value: 6050
        /// </summary>
        CustomQuotaPerRoomDisabled = 6050,

        /// <summary>
        /// Enum CustomQuotaPerUserDefault for value: 6051
        /// </summary>
        CustomQuotaPerUserDefault = 6051,

        /// <summary>
        /// Enum CustomQuotaPerUserChanged for value: 6052
        /// </summary>
        CustomQuotaPerUserChanged = 6052,

        /// <summary>
        /// Enum CustomQuotaPerUserDisabled for value: 6053
        /// </summary>
        CustomQuotaPerUserDisabled = 6053,

        /// <summary>
        /// Enum DevToolsAccessSettingsChanged for value: 6054
        /// </summary>
        DevToolsAccessSettingsChanged = 6054,

        /// <summary>
        /// Enum WebhookCreated for value: 6055
        /// </summary>
        WebhookCreated = 6055,

        /// <summary>
        /// Enum WebhookUpdated for value: 6056
        /// </summary>
        WebhookUpdated = 6056,

        /// <summary>
        /// Enum WebhookDeleted for value: 6057
        /// </summary>
        WebhookDeleted = 6057,

        /// <summary>
        /// Enum ApiKeyCreated for value: 6058
        /// </summary>
        ApiKeyCreated = 6058,

        /// <summary>
        /// Enum ApiKeyUpdated for value: 6059
        /// </summary>
        ApiKeyUpdated = 6059,

        /// <summary>
        /// Enum ApiKeyDeleted for value: 6060
        /// </summary>
        ApiKeyDeleted = 6060,

        /// <summary>
        /// Enum CustomerWalletToppedUp for value: 6061
        /// </summary>
        CustomerWalletToppedUp = 6061,

        /// <summary>
        /// Enum CustomerOperationPerformed for value: 6062
        /// </summary>
        CustomerOperationPerformed = 6062,

        /// <summary>
        /// Enum CustomerOperationsReportDownloaded for value: 6063
        /// </summary>
        CustomerOperationsReportDownloaded = 6063,

        /// <summary>
        /// Enum CustomerWalletTopUpSettingsUpdated for value: 6064
        /// </summary>
        CustomerWalletTopUpSettingsUpdated = 6064,

        /// <summary>
        /// Enum CustomerSubscriptionUpdated for value: 6065
        /// </summary>
        CustomerSubscriptionUpdated = 6065,

        /// <summary>
        /// Enum BannerSettingsChanged for value: 6066
        /// </summary>
        BannerSettingsChanged = 6066,

        /// <summary>
        /// Enum ContactAdminMailSent for value: 7000
        /// </summary>
        ContactAdminMailSent = 7000,

        /// <summary>
        /// Enum RoomInviteLinkUsed for value: 7001
        /// </summary>
        RoomInviteLinkUsed = 7001,

        /// <summary>
        /// Enum UserCreatedAndAddedToRoom for value: 7002
        /// </summary>
        UserCreatedAndAddedToRoom = 7002,

        /// <summary>
        /// Enum GuestCreatedAndAddedToRoom for value: 7003
        /// </summary>
        GuestCreatedAndAddedToRoom = 7003,

        /// <summary>
        /// Enum ContactSalesMailSent for value: 7004
        /// </summary>
        ContactSalesMailSent = 7004,

        /// <summary>
        /// Enum CreateClient for value: 9901
        /// </summary>
        CreateClient = 9901,

        /// <summary>
        /// Enum UpdateClient for value: 9902
        /// </summary>
        UpdateClient = 9902,

        /// <summary>
        /// Enum RegenerateSecret for value: 9903
        /// </summary>
        RegenerateSecret = 9903,

        /// <summary>
        /// Enum DeleteClient for value: 9904
        /// </summary>
        DeleteClient = 9904,

        /// <summary>
        /// Enum ChangeClientActivation for value: 9905
        /// </summary>
        ChangeClientActivation = 9905,

        /// <summary>
        /// Enum ChangeClientVisibility for value: 9906
        /// </summary>
        ChangeClientVisibility = 9906,

        /// <summary>
        /// Enum RevokeUserClient for value: 9907
        /// </summary>
        RevokeUserClient = 9907,

        /// <summary>
        /// Enum GenerateAuthorizationCodeToken for value: 9908
        /// </summary>
        GenerateAuthorizationCodeToken = 9908,

        /// <summary>
        /// Enum GeneratePersonalAccessToken for value: 9909
        /// </summary>
        GeneratePersonalAccessToken = 9909,

        /// <summary>
        /// Enum None for value: -1
        /// </summary>
        None = -1
    }

}
