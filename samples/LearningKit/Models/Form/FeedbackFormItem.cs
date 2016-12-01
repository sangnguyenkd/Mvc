﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.OnlineForms.Types;
using CMS.OnlineForms;

[assembly: RegisterBizForm(FeedbackFormItem.CLASS_NAME, typeof(FeedbackFormItem))]

namespace CMS.OnlineForms.Types
{
    /// <summary>
    /// Represents a content item of type FeedbackFormItem.
    /// </summary>
    public partial class FeedbackFormItem : BizFormItem
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "BizForm.FeedbackForm";


        /// <summary>
        /// The instance of the class that provides extended API for working with FeedbackFormItem fields.
        /// </summary>
        private readonly FeedbackFormItemFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// 
        /// </summary>
        [DatabaseField]
        public string UserName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("UserName"), "");
            }
            set
            {
                SetValue("UserName", value);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [DatabaseField]
        public string UserLastName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("UserLastName"), "");
            }
            set
            {
                SetValue("UserLastName", value);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [DatabaseField]
        public string UserEmail
        {
            get
            {
                return ValidationHelper.GetString(GetValue("UserEmail"), "");
            }
            set
            {
                SetValue("UserEmail", value);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [DatabaseField]
        public string UserFeedback
        {
            get
            {
                return ValidationHelper.GetString(GetValue("UserFeedback"), "");
            }
            set
            {
                SetValue("UserFeedback", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with FeedbackFormItem fields.
        /// </summary>
        [RegisterProperty]
        public FeedbackFormItemFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with FeedbackFormItem fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class FeedbackFormItemFields : AbstractHierarchicalObject<FeedbackFormItemFields>
        {
            /// <summary>
            /// The content item of type FeedbackFormItem that is a target of the extended API.
            /// </summary>
            private readonly FeedbackFormItem mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="FeedbackFormItemFields" /> class with the specified content item of type FeedbackFormItem.
            /// </summary>
            /// <param name="instance">The content item of type FeedbackFormItem that is a target of the extended API.</param>
            public FeedbackFormItemFields(FeedbackFormItem instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// 
            /// </summary>
            public string UserName
            {
                get
                {
                    return mInstance.UserName;
                }
                set
                {
                    mInstance.UserName = value;
                }
            }


            /// <summary>
            /// 
            /// </summary>
            public string UserLastName
            {
                get
                {
                    return mInstance.UserLastName;
                }
                set
                {
                    mInstance.UserLastName = value;
                }
            }


            /// <summary>
            /// 
            /// </summary>
            public string UserEmail
            {
                get
                {
                    return mInstance.UserEmail;
                }
                set
                {
                    mInstance.UserEmail = value;
                }
            }


            /// <summary>
            /// 
            /// </summary>
            public string UserFeedback
            {
                get
                {
                    return mInstance.UserFeedback;
                }
                set
                {
                    mInstance.UserFeedback = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFormItem" /> class.
        /// </summary>
        public FeedbackFormItem() : base(CLASS_NAME)
        {
            mFields = new FeedbackFormItemFields(this);
        }

        #endregion
    }
}