﻿/*
    实体生成配置项
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.AssistTools.Modules
{
    public class EntityConfiguration
    {


        public EntityConfiguration()
        {
            this.IsFirst = false;
            this.IsCover = false;
            this.UseApplication = true;
            this.UseAuthorization = false;
            this.UseDomainService = true;
        }

        /// <summary>
        /// 是否首次使用
        /// </summary>
        public bool IsFirst { get; set; }

        /// <summary>
        /// 是否覆盖文件
        /// </summary>
        public bool IsCover { get; set; }

        /// <summary>
        /// 是否生成领域服务
        /// </summary>
        public bool UseApplication { get; set; }

        /// <summary>
        /// 是否生成权限服务
        /// </summary>
        public bool UseAuthorization { get; set; }


        /// <summary>
        /// 是否生成领域服务
        /// </summary>
        public bool UseDomainService { get; set; }
    }
}
