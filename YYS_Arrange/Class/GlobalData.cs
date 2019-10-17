using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYS_Arrange.Class
{
    /// <summary>
    /// 全局数据存贮类
    /// </summary>
    class GlobalData
    {
        /// <summary>
        /// 用于存贮整个JSON信息的类
        /// </summary>
        public static Root root = new Root();
        /// <summary>
        /// SP式神数量
        /// </summary>
        public static int hero_sp = 0;
        /// <summary>
        /// SSR式神数量
        /// </summary>
        public static int hero_ssr = 0;
        /// <summary>
        /// SR式神数量
        /// </summary>
        public static int hero_sr = 0;
        /// <summary>
        /// R式神数量
        /// </summary>
        public static int hero_r = 0;
        /// <summary>
        /// N式神数量
        /// </summary>
        public static int hero_n = 0;
        /// <summary>
        /// 素材数量
        /// </summary>
        public static int hero_sucai = 0;
    }
}
