﻿using System.Collections.Generic;

namespace CASCLib
{
    public class KeyService
    {
        private static Dictionary<ulong, byte[]> keys = new Dictionary<ulong, byte[]>()
        {
            // hardcoded Overwatch keys
            [0xFB680CB6A8BF81F3] = "62D90EFA7F36D71C398AE2F1FE37BDB9".ToByteArray(),
            [0x402CD9D8D6BFED98] = "AEB0EADEA47612FE6C041A03958DF241".ToByteArray(),
            // streamed Overwatch keys
            [0xDBD3371554F60306] = "34E397ACE6DD30EEFDC98A2AB093CD3C".ToByteArray(),
            [0x11A9203C9881710A] = "2E2CB8C397C2F24ED0B5E452F18DC267".ToByteArray(),
            [0xA19C4F859F6EFA54] = "0196CB6F5ECBAD7CB5283891B9712B4B".ToByteArray(),
            [0x87AEBBC9C4E6B601] = "685E86C6063DFDA6C9E85298076B3D42".ToByteArray(),
            [0xDEE3A0521EFF6F03] = "AD740CE3FFFF9231468126985708E1B9".ToByteArray(),
            [0x8C9106108AA84F07] = "53D859DDA2635A38DC32E72B11B32F29".ToByteArray(),
            [0x49166D358A34D815] = "667868CD94EA0135B9B16C93B1124ABA".ToByteArray(),
            [0x1463A87356778D14] = "69BD2A78D05C503E93994959B30E5AEC".ToByteArray(),
            [0x5E152DE44DFBEE01] = "E45A1793B37EE31A8EB85CEE0EEE1B68".ToByteArray(),
            [0x9B1F39EE592CA415] = "54A99F081CAD0D08F7E336F4368E894C".ToByteArray(),
            [0x24C8B75890AD5917] = "31100C00FDE0CE18BBB33F3AC15B309F".ToByteArray(),
            [0xEA658B75FDD4890F] = "DEC7A4E721F425D133039895C36036F8".ToByteArray(),
            [0x026FDCDF8C5C7105] = "8F41809DA55366AD416D3C337459EEE3".ToByteArray(),
            [0xCAE3FAC925F20402] = "98B78E8774BF275093CB1B5FC714511B".ToByteArray(),
            [0x061581CA8496C80C] = "DA2EF5052DB917380B8AA6EF7A5F8E6A".ToByteArray(),
            [0xBE2CB0FAD3698123] = "902A1285836CE6DA5895020DD603B065".ToByteArray(),
            [0x57A5A33B226B8E0A] = "FDFC35C99B9DB11A326260CA246ACB41".ToByteArray(),
            [0x42B9AB1AF5015920] = "C68778823C964C6F247ACC0F4A2584F8".ToByteArray(),
            [0x4F0FE18E9FA1AC1A] = "89381C748F6531BBFCD97753D06CC3CD".ToByteArray(),
            [0x7758B2CF1E4E3E1B] = "3DE60D37C664723595F27C5CDBF08BFA".ToByteArray(),
            [0xE5317801B3561125] = "7DD051199F8401F95E4C03C884DCEA33".ToByteArray(),
            [0x16B866D7BA3A8036] = "1395E882BF25B481F61A4D621141DA6E".ToByteArray(),
            [0x11131FFDA0D18D30] = "C32AD1B82528E0A456897B3CE1C2D27E".ToByteArray(),
            [0xCAC6B95B2724144A] = "73E4BEA145DF2B89B65AEF02F83FA260".ToByteArray(),
            [0xB7DBC693758A5C36] = "BC3A92BFE302518D91CC30790671BF10".ToByteArray(),
            [0x90CA73B2CDE3164B] = "5CBFF11F22720BACC2AE6AAD8FE53317".ToByteArray(),
            [0x6DD3212FB942714A] = "E02C1643602EC16C3AE2A4D254A08FD9".ToByteArray(),
            [0x11DDB470ABCBA130] = "66198766B1C4AF7589EFD13AD4DD667A".ToByteArray(),
            [0x5BEF27EEE95E0B4B] = "36BCD2B551FF1C84AA3A3994CCEB033E".ToByteArray(),
            [0x9359B46E49D2DA42] = "173D65E7FCAE298A9363BD6AA189F200".ToByteArray(),
            [0x1A46302EF8896F34] = "8029AD5451D4BC18E9D0F5AC449DC055".ToByteArray(),
            [0x693529F7D40A064C] = "CE54873C62DAA48EFF27FCC032BD07E3".ToByteArray(),
            [0x388B85AEEDCB685D] = "D926E659D04A096B24C19151076D379A".ToByteArray(),
            // streamed WoW keys
            [0xFA505078126ACB3E] = "BDC51862ABED79B2DE48C8E7E66C6200".ToByteArray(), // TactKeyId 15
            [0xFF813F7D062AC0BC] = "AA0B5C77F088CCC2D39049BD267F066D".ToByteArray(), // TactKeyId 25
            [0xD1E9B5EDF9283668] = "8E4A2579894E38B4AB9058BA5C7328EE".ToByteArray(), // TactKeyId 39
            [0xB76729641141CB34] = "9849D1AA7B1FD09819C5C66283A326EC".ToByteArray(), // TactKeyId 40
            [0xFFB9469FF16E6BF8] = "D514BD1909A9E5DC8703F4B8BB1DFD9A".ToByteArray(), // TactKeyId 41
            [0x23C5B5DF837A226C] = "1406E2D873B6FC99217A180881DA8D62".ToByteArray(), // TactKeyId 42
            //[0x3AE403EF40AC3037] = "????????????????????????????????".ToByteArray(), // TactKeyId 51
            [0xE2854509C471C554] = "433265F0CDEB2F4E65C0EE7008714D9E".ToByteArray(), // TactKeyId 52
            [0x8EE2CB82178C995A] = "DA6AFC989ED6CAD279885992C037A8EE".ToByteArray(), // TactKeyId 55
            [0x5813810F4EC9B005] = "01BE8B43142DD99A9E690FAD288B6082".ToByteArray(), // TactKeyId 56
            [0x7F9E217166ED43EA] = "05FC927B9F4F5B05568142912A052B0F".ToByteArray(), // TactKeyId 57
            [0xC4A8D364D23793F7] = "D1AC20FD14957FABC27196E9F6E7024A".ToByteArray(), // TactKeyId 58
            [0x40A234AEBCF2C6E5] = "C6C5F6C7F735D7D94C87267FA4994D45".ToByteArray(), // TactKeyId 59
            [0x9CF7DFCFCBCE4AE5] = "72A97A24A998E3A5500F3871F37628C0".ToByteArray(), // TactKeyId 60
            [0x4E4BDECAB8485B4F] = "3832D7C42AAC9268F00BE7B6B48EC9AF".ToByteArray(), // TactKeyId 61
            [0x94A50AC54EFF70E4] = "C2501A72654B96F86350C5A927962F7A".ToByteArray(), // TactKeyId 62
            [0xBA973B0E01DE1C2C] = "D83BBCB46CC438B17A48E76C4F5654A3".ToByteArray(), // TactKeyId 63
            [0x494A6F8E8E108BEF] = "F0FDE1D29B274F6E7DBDB7FF815FE910".ToByteArray(), // TactKeyId 64
            [0x918D6DD0C3849002] = "857090D926BB28AEDA4BF028CACC4BA3".ToByteArray(), // TactKeyId 65
            [0x0B5F6957915ADDCA] = "4DD0DC82B101C80ABAC0A4D57E67F859".ToByteArray(), // TactKeyId 66
            [0x794F25C6CD8AB62B] = "76583BDACD5257A3F73D1598A2CA2D99".ToByteArray(), // TactKeyId 67
            [0xA9633A54C1673D21] = "1F8D467F5D6D411F8A548B6329A5087E".ToByteArray(), // TactKeyId 68
            [0x5E5D896B3E163DEA] = "8ACE8DB169E2F98AC36AD52C088E77C1".ToByteArray(), // TactKeyId 69
            [0x0EBE36B5010DFD7F] = "9A89CC7E3ACB29CF14C60BC13B1E4616".ToByteArray(), // TactKeyId 70
            [0x01E828CFFA450C0F] = "972B6E74420EC519E6F9D97D594AA37C".ToByteArray(), // TactKeyId 71
            [0x4A7BD170FE18E6AE] = "AB55AE1BF0C7C519AFF028C15610A45B".ToByteArray(), // TactKeyId 72
            [0x69549CB975E87C4F] = "7B6FA382E1FAD1465C851E3F4734A1B3".ToByteArray(), // TactKeyId 73
            [0x460C92C372B2A166] = "946D5659F2FAF327C0B7EC828B748ADB".ToByteArray(), // TactKeyId 74
            [0x8165D801CCA11962] = "CD0C0FFAAD9363EC14DD25ECDD2A5B62".ToByteArray(), // TactKeyId 75
            [0xA3F1C999090ADAC9] = "B72FEF4A01488A88FF02280AA07A92BB".ToByteArray(), // TactKeyId 81
            //[0x18AFDF5191923610] = "????????????????????????????????".ToByteArray(), // TactKeyId 82
            //[0x3C258426058FBD93] = "????????????????????????????????".ToByteArray(), // TactKeyId 91
            [0x094E9A0474876B98] = "E533BB6D65727A5832680D620B0BC10B".ToByteArray(), // TactKeyId 92
            [0x3DB25CB86A40335E] = "02990B12260C1E9FDD73FE47CBAB7024".ToByteArray(), // TactKeyId 93
            [0x0DCD81945F4B4686] = "1B789B87FB3C9238D528997BFAB44186".ToByteArray(), // TactKeyId 94
            [0x486A2A3A2803BE89] = "32679EA7B0F99EBF4FA170E847EA439A".ToByteArray(), // TactKeyId 95
            [0x71F69446AD848E06] = "E79AEB88B1509F628F38208201741C30".ToByteArray(), // TactKeyId 97
            [0x211FCD1265A928E9] = "A736FBF58D587B3972CE154A86AE4540".ToByteArray(), // TactKeyId 98
            [0x0ADC9E327E42E98C] = "017B3472C1DEE304FA0B2FF8E53FF7D6".ToByteArray(), // TactKeyId 99
            [0xBAE9F621B60174F1] = "38C3FB39B4971760B4B982FE9F095014".ToByteArray(), // TactKeyId 100
            [0x34DE1EEADC97115E] = "2E3A53D59A491E5CD173F337F7CD8C61".ToByteArray(), // TactKeyId 101
            [0xE07E107F1390A3DF] = "290D27B0E871F8C5B14A14E514D0F0D9".ToByteArray(), // TactKeyId 102
            [0x32690BF74DE12530] = "A2556210AE5422E6D61EDAAF122CB637".ToByteArray(), // TactKeyId 103
            [0xBF3734B1DCB04696] = "48946123050B00A7EFB1C029EE6CC438".ToByteArray(), // TactKeyId 104
            [0x74F4F78002A5A1BE] = "C14EEC8D5AEEF93FA811D450B4E46E91".ToByteArray(), // TactKeyId 105
            //[0x423F07656CA27D23] = "????????????????????????????????".ToByteArray(), // TactKeyId 107
            //[0x0691678F83E8A75D] = "????????????????????????????????".ToByteArray(), // TactKeyId 108
            //[0x324498590F550556] = "????????????????????????????????".ToByteArray(), // TactKeyId 109
            //[0xC02C78F40BEF5998] = "????????????????????????????????".ToByteArray(), // TactKeyId 110
            //[0x47011412CCAAB541] = "????????????????????????????????".ToByteArray(), // TactKeyId 111
            //[0x23B6F5764CE2DDD6] = "????????????????????????????????".ToByteArray(), // TactKeyId 112
            //[0x8E00C6F405873583] = "????????????????????????????????".ToByteArray(), // TactKeyId 113
            [0x78482170E4CFD4A6] = "768540C20A5B153583AD7F53130C58FE".ToByteArray(), // TactKeyId 114
            [0xB1EB52A64BFAF7BF] = "458133AA43949A141632C4F8596DE2B0".ToByteArray(), // TactKeyId 115
            [0xFC6F20EE98D208F6] = "57790E48D35500E70DF812594F507BE7".ToByteArray(), // TactKeyId 117
            [0x402CFABF2020D9B7] = "67197BCD9D0EF0C4085378FAA69A3264".ToByteArray(), // TactKeyId 118
            [0x6FA0420E902B4FBE] = "27B750184E5329C4E4455CBD3E1FD5AB".ToByteArray(), // TactKeyId 119
            [0x1076074F2B350A2D] = "88BF0CD0D5BA159AE7CB916AFBE13865".ToByteArray(), // TactKeyId 121
            [0x816F00C1322CDF52] = "6F832299A7578957EE86B7F9F15B0188".ToByteArray(), // TactKeyId 122
            [0xDDD295C82E60DB3C] = "3429CC5927D1629765974FD9AFAB7580".ToByteArray(), // TactKeyId 123
            [0x83E96F07F259F799] = "91F7D0E7A02CDE0DE0BD367FABCB8A6E".ToByteArray(), // TactKeyId 124
            [0x49FBFE8A717F03D5] = "C7437770CF153A3135FA6DC5E4C85E65".ToByteArray(), // TactKeyId 225
            [0xC1E5D7408A7D4484] = "A7D88E52749FA5459D644523F8359651".ToByteArray(), // TactKeyId 226
            [0xE46276EB9E1A9854] = "CCCA36E302F9459B1D60526A31BE77C8".ToByteArray(), // TactKeyId 227
            [0xD245B671DD78648C] = "19DCB4D45A658B54351DB7DDC81DE79E".ToByteArray(), // TactKeyId 228
            [0x4C596E12D36DDFC3] = "B8731926389499CBD4ADBF5006CA0391".ToByteArray(), // TactKeyId 229
            [0x0C9ABD5081C06411] = "25A77CD800197EE6A32DD63F04E115FA".ToByteArray(), // TactKeyId 230
            [0x3C6243057F3D9B24] = "58AE3E064210E3EDF9C1259CDE914C5D".ToByteArray(), // TactKeyId 231
            [0x7827FBE24427E27D] = "34A432042073CD0B51627068D2E0BD3E".ToByteArray(), // TactKeyId 232
            [0xFAF9237E1186CF66] = "AE787840041E9B4198F479714DAD562C".ToByteArray(), // TactKeyId 233
            //[0x5DD92EE32BBF9ABD] = "????????????????????????????????".ToByteArray(), // TactKeyId 234
            [0x0B68A7AF5F85F7EE] = "27AA011082F5E8BBBD71D1BA04F6ABA4".ToByteArray(), // TactKeyId 236
            //[0x01531713C83FCC39] = "????????????????????????????????".ToByteArray(), // TactKeyId 237
            [0x76E4F6739A35E8D7] = "05CF276722E7165C5A4F6595256A0BFB".ToByteArray(), // TactKeyId 238
            [0x66033F28DC01923C] = "9F9519861490C5A9FFD4D82A6D0067DB".ToByteArray(), // TactKeyId 239
            [0xFCF34A9B05AE7E6A] = "E7C2C8F77E30AC240F39EC23971296E5".ToByteArray(), // TactKeyId 240
            [0xE2F6BD41298A2AB9] = "C5DC1BB43B8CF3F085D6986826B928EC".ToByteArray(), // TactKeyId 241
            [0x14C4257E557B49A1] = "064A9709F42D50CB5F8B94BC1ACFDD5D".ToByteArray(), // TactKeyId 242
            [0x1254E65319C6EEFF] = "79D2B3D1CCB015474E7158813864B8E6".ToByteArray(), // TactKeyId 243
            [0xC8753773ADF1174C] = "1E0E37D42EE5CE5E8067F0394B0905F2".ToByteArray(), // TactKeyId 244
            //[0x2170BCAA9FA96E22] = "????????????????????????????????".ToByteArray(), // TactKeyId 245
            //[0x75485627AA225F4D] = "????????????????????????????????".ToByteArray(), // TactKeyId 246
            [0x08717B15BF3C7955] = "4B06BF9D17663CEB3312EA3C69FBC5DD".ToByteArray(), // TactKeyId 248
            //[0xD19DCF7ACA8D96D6] = "????????????????????????????????".ToByteArray(), // TactKeyId 249
            [0x9FD609902B4B2E07] = "ABE0C5F9C123E6E24E7BEA43C2BF00AC".ToByteArray(), // TactKeyId 250
            //[0xCB26B441FAE4C8CD] = "????????????????????????????????".ToByteArray(), // TactKeyId 251
            [0xA98C7594F55C02F0] = "EEDB77473B721DED6204A976C9A661E7".ToByteArray(), // TactKeyId 252
            [0x259EE68CD9E76DBA] = "465D784F1019661CCF417FE466801283".ToByteArray(), // TactKeyId 253
            [0x6A026290FBDB3754] = "3D2D620850A6765DD591224F605B949A".ToByteArray(), // TactKeyId 255
            [0xCF72FD04608D36ED] = "A0A889976D02FA8D00F7AF0017AD721F".ToByteArray(), // TactKeyId 257
            [0x17F07C2E3A45DB3D] = "6D3886BDB91E715AE7182D9F3A08F2C9".ToByteArray(), // TactKeyId 258
            //[0xDFAB5841B87802B5] = "????????????????????????????????".ToByteArray(), // TactKeyId 259
            [0xC050FA06BB0538F6] = "C552F5D0B72231502D2547314E6015F7".ToByteArray(), // TactKeyId 260
            [0xAB5CDD3FC321831F] = "E1384F5B06EBBCD333695AA6FFC68318".ToByteArray(), // TactKeyId 261
            [0xA7B7D1F12395040E] = "36AD3B31273F1EBCEE8520AAA74B12F2".ToByteArray(), // TactKeyId 262
            [0x83A2AB72DD8AE992] = "023CFF062B19A529B9F14F9B7AAAC5BB".ToByteArray(), // TactKeyId 263
            [0xBEAF567CC45362F0] = "8BD3ED792405D9EE742BF6AFA944578A".ToByteArray(), // TactKeyId 264
            [0x7BB3A77FD8D14783] = "4C94E3609CFE0A82000A0BD46069AC6F".ToByteArray(), // TactKeyId 265
            [0x8F4098E2470FE0C8] = "AA718D1F1A23078D49AD0C606A72F3D5".ToByteArray(), // TactKeyId 266
            //[0x6AC5C837A2027A6B] = "????????????????????????????????".ToByteArray(), // TactKeyId 267
            [0x302AAD8B1F441D95] = "24B86438CF02538649E5BA672FD5993A".ToByteArray(), // TactKeyId 271
            //[0x5C909F00088734B9] = "????????????????????????????????".ToByteArray(), // TactKeyId 272
            //[0xF785977C76DE9C77] = "????????????????????????????????".ToByteArray(), // TactKeyId 273
            //[0x1CDAF3931871BEC3] = "????????????????????????????????".ToByteArray(), // TactKeyId 275
            [0x814E1AB43F3F9345] = "B65E2A63A116AA251FA5D7B0BAABF778".ToByteArray(), // TactKeyId 276
            [0x1FBE97A317FFBEFA] = "BD71F78D43117C68724BB6E0D9577E08".ToByteArray(), // TactKeyId 277
            //[0x4287F49A5BB366DA] = "????????????????????????????????".ToByteArray(), // TactKeyId 279
            //[0x01C82EE0725EDA3A] = "????????????????????????????????".ToByteArray(), // TactKeyId 281
            //[0x04C0C50B5BE0CC78] = "????????????????????????????????".ToByteArray(), // TactKeyId 282
            //[0xA26FD104489B3DE5] = "????????????????????????????????".ToByteArray(), // TactKeyId 283
            // BNA 1.5.0 Alpha
            [0x2C547F26A2613E01] = "37C50C102D4C9E3A5AC069F072B1417D".ToByteArray(),
        };

        public static Salsa20 SalsaInstance { get; } = new Salsa20();

        public static byte[] GetKey(ulong keyName)
        {
            keys.TryGetValue(keyName, out byte[] key);
            return key;
        }

        public static void SetKey(ulong keyName, byte[] key) => keys[keyName] = key;
    }
}
