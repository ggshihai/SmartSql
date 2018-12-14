﻿using SmartSql.Abstractions;
using SmartSql.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSql.Configuration.Tags
{
    public class IsLessEqual : CompareTag
    {
        public override TagType Type => TagType.IsLessEqual;

        public override bool IsCondition(RequestContext context)
        {
            Object reqVal = GetPropertyValue(context);
            if (reqVal == null) { return false; }
            Decimal reqValNum = 0M;
            Decimal comVal = 0M;
            if (reqVal is Enum)
            {
                reqValNum = (Decimal)EnumUtils.ToRealValue(reqVal);
            }
            else
            {
                if (!Decimal.TryParse(reqVal.ToString(), out reqValNum)) { return false; }
            }
            if (!Decimal.TryParse(CompareValue, out comVal)) { return false; }
            return reqValNum <= comVal;
        }
    }
}
