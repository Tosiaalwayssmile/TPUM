//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/
//Browse name: User


using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;

namespace CodeGenerated
{
    public class ObjectType_User_1274949547_0 : CodeGenObjectTypeBase
    {        
        public ObjectType_User_1274949547_0(string browseName,
                               string typeId, ushort typeNamespaceIndex, IdType typeNodeIdType,
                               string nodeId, ushort namespaceIndex, IdType nodeIdType,
                               string parentNodeId, ushort parentNamespaceIndex, IdType parentNodeIdType
                               ) : base(browseName, 
                                        typeId, typeNamespaceIndex, typeNodeIdType,
                                        nodeId, namespaceIndex, nodeIdType,
                                        parentNodeId, parentNamespaceIndex, parentNodeIdType)
        {
            //constructor
        }


        public override bool Initialize(Dictionary<CodeGenNodeID, CodeGenNodeID> childrenIDMap,
                                        CodeGenNodeManager addressSpaceMgr)
        {
            Console.WriteLine("ObjectType_User_1274949547_0::Initialize");

            bool success = true;   
            
            m_addressSpaceMgr = addressSpaceMgr;
            ushort namespaceIndex = 0;

            // Set attributes
            this.GetNode().BrowseName  = "User";
            this.GetNode().DisplayName = "User";
            this.GetNode().Description = "";
            this.GetNode().WriteMask = AttributeWriteMask.None
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        ;
                                        
            //Create Children objects
            
            {
            string childBrowseName = "Cart";
    string childFileNoExtension = "type_ObjectType_Cart_126007880_0";
    string childSourceId = "Cart_User";
    ushort childSourceNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    string childTypeDefId = "Cart_User";
    int childTypeDefNamespaceIndex =  m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childTypeDefNodeIdType = 1;

    obj_Cart_126007880_0 = (ObjectType_Cart_126007880_0)                                                                                              
            (m_addressSpaceMgr.CreateObject(childrenIDMap,                                                              
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType));                                                            
    ObjectType_Cart_126007880_0 local = obj_Cart_126007880_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
       
            }
            
            
            //Create Children variables
            
            {
            string childBrowseName = "Phone";
    string childFileNoExtension = "type_VariableType_Phone_683592124_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "12";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "Phone";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_Phone_683592124_0 = (VariableType_Phone_683592124_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_Phone_683592124_0 local = var_Phone_683592124_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            {
            string childBrowseName = "Email";
    string childFileNoExtension = "type_VariableType_Email_408304690_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "12";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "Email";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_Email_408304690_0 = (VariableType_Email_408304690_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_Email_408304690_0 local = var_Email_408304690_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            {
            string childBrowseName = "LastName";
    string childFileNoExtension = "type_VariableType_LastName_1252332858_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "12";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "LastName";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_LastName_1252332858_0 = (VariableType_LastName_1252332858_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_LastName_1252332858_0 local = var_LastName_1252332858_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            {
            string childBrowseName = "Guid";
    string childFileNoExtension = "type_VariableType_Guid_708606687_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "14";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "Guid_User";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_Guid_708606687_0 = (VariableType_Guid_708606687_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_Guid_708606687_0 local = var_Guid_708606687_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            {
            string childBrowseName = "FirstName";
    string childFileNoExtension = "type_VariableType_FirstName_350218717_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "12";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "FirstName";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_FirstName_350218717_0 = (VariableType_FirstName_350218717_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_FirstName_350218717_0 local = var_FirstName_350218717_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
            
            local.SetDataType(childDataTypeId, childDataTypeNamespaceIndex, (IdType)childDataTypeNodeIdType);
            }
            
            
            //Create Children properties
            
            
            //Create Children methods
            
            
            
            return success;
        }

        public override BaseObjectState GetNode()
        {
            return m_node;
        }

        public override void SetNode(BaseObjectState node)
        {
            m_node  = node;
            m_inode = node;
        }
        
        #region Public Fields
        /* Children objects */  
            public ObjectType_Cart_126007880_0 obj_Cart_126007880_0;


            /* Children variables */
            public VariableType_Phone_683592124_0 var_Phone_683592124_0;
    public VariableType_Email_408304690_0 var_Email_408304690_0;
    public VariableType_LastName_1252332858_0 var_LastName_1252332858_0;
    public VariableType_Guid_708606687_0 var_Guid_708606687_0;
    public VariableType_FirstName_350218717_0 var_FirstName_350218717_0;


            /* Children properties */
        

            /* Children methods */
        
        #endregion
    }
}
