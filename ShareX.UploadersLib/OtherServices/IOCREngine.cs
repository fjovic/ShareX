﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareX.UploadersLib.OtherServices
{
    public enum Languages
    {
        [Description("Arabic")]
        ara,
        [Description("Bulgarian")]
        bul,
        [Description("Chinese (Simplified)")]
        chs,
        [Description("Chinese (Traditional)")]
        cht,
        [Description("Croatian")]
        hrv,
        [Description("Czech")]
        cze,
        [Description("Danish")]
        dan,
        [Description("Dutch")]
        dut,
        [Description("English")]
        eng,
        [Description("Finnish")]
        fin,
        [Description("French")]
        fre,
        [Description("German")]
        ger,
        [Description("Greek")]
        gre,
        [Description("Hungarian")]
        hun,
        [Description("Korean")]
        kor,
        [Description("Italian")]
        ita,
        [Description("Japanese")]
        jpn,
        [Description("Norwegian")]
        nor,
        [Description("Polish")]
        pol,
        [Description("Portuguese")]
        por,
        [Description("Russian")]
        rus,
        [Description("Slovenian")]
        slv,
        [Description("Spanish")]
        spa,
        [Description("Swedish")]
        swe,
        [Description("Turkish")]
        tur
    }

    public enum Languages2
    {
        [Description("Azerbaijan")]
        az,
        [Description("Albanian")]
        sq,
        [Description("Amharic")]
        am,
        [Description("English")]
        en,
        [Description("Arabic")]
        ar,
        [Description("Armenian")]
        hy,
        [Description("Afrikaans")]
        af,
        [Description("Basque")]
        eu,
        [Description("Bashkir")]
        ba,
        [Description("Belarusian")]
        be,
        [Description("Bengali")]
        bn,
        [Description("Burmese")]
        my,
        [Description("Bulgarian")]
        bg,
        [Description("Bosnian")]
        bs,
        [Description("Welsh")]
        cy,
        [Description("Hungarian")]
        hu,
        [Description("Vietnamese")]
        vi,
        [Description("Haitian (Creole)")]
        ht,
        [Description("Galician")]
        gl,
        [Description("Dutch")]
        nl,
        [Description("Hill Mari")]
        mrj,
        [Description("Greek")]
        el,
        [Description("Georgian")]
        ka,
        [Description("Gujarati")]
        gu,
        [Description("Danish")]
        da,
        [Description("Hebrew")]
        he,
        [Description("Yiddish")]
        yi,
        [Description("Indonesian")]
        id,
        [Description("Irish")]
        ga,
        [Description("Italian")]
        it,
        [Description("Icelandic")]
        @is,
        [Description("Spanish")]
        es,
        [Description("Kazakh")]
        kk,
        [Description("Kannada")]
        kn,
        [Description("Catalan")]
        ca,
        [Description("Kyrgyz")]
        ky,
        [Description("Chinese (Simplified)")]
        zh,
        [Description("Korean")]
        ko,
        [Description("Xhosa")]
        xh,
        [Description("Khmer")]
        km,
        [Description("Laotian")]
        lo,
        [Description("Latin")]
        la,
        [Description("Latvian")]
        lv,
        [Description("Lithuanian")]
        lt,
        [Description("Luxembourgish")]
        lb,
        [Description("Malagasy")]
        mg,
        [Description("Malay")]
        ms,
        [Description("Malayalam")]
        ml,
        [Description("Maltese")]
        mt,
        [Description("Macedonian")]
        mk,
        [Description("Maori")]
        mi,
        [Description("Marathi")]
        mr,
        [Description("Mari")]
        mhr,
        [Description("Mongolian")]
        mn,
        [Description("German")]
        de,
        [Description("Nepali")]
        ne,
        [Description("Norwegian")]
        no,
        [Description("Punjabi")]
        pa,
        [Description("Papiamento")]
        pap,
        [Description("Persian")]
        fa,
        [Description("Polish")]
        pl,
        [Description("Portuguese")]
        pt,
        [Description("Romanian")]
        ro,
        [Description("Russian")]
        ru,
        [Description("Cebuano")]
        ceb,
        [Description("Serbian")]
        sr,
        [Description("Sinhala")]
        si,
        [Description("Slovakian")]
        sk,
        [Description("Slovenian")]
        sl,
        [Description("Swahili")]
        sw,
        [Description("Sundanese")]
        su,
        [Description("Tajik")]
        tg,
        [Description("Thai")]
        th,
        [Description("Tagalog")]
        tl,
        [Description("Tamil")]
        ta,
        [Description("Tatar")]
        tt,
        [Description("Telugu")]
        te,
        [Description("Turkish")]
        tr,
        [Description("Udmurt")]
        udm,
        [Description("Uzbek")]
        uz,
        [Description("Ukrainian")]
        uk,
        [Description("Urdu")]
        ur,
        [Description("Finnish")]
        fi,
        [Description("French")]
        fr,
        [Description("Hindi")]
        hi,
        [Description("Croatian")]
        hr,
        [Description("Czech")]
        cs,
        [Description("Swedish")]
        sv,
        [Description("Scottish")]
        gd,
        [Description("Estonian")]
        et,
        [Description("Esperanto")]
        eo,
        [Description("Javanese")]
        jv,
        [Description("Japanese")]
        ja
    }

    interface IOCREngine
    {
        string DoOCR(Stream stream, Languages language);
    }
}