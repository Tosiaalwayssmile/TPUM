//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/
//Browse name: Cart


using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;

namespace CodeGenerated
{
    public class ObjectType_Cart_126007880_0 : CodeGenObjectTypeBase
    {        
        public ObjectType_Cart_126007880_0(string browseName,
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
            Console.WriteLine("ObjectType_Cart_126007880_0::Initialize");

            bool success = true;   
            
            m_addressSpaceMgr = addressSpaceMgr;
            ushort namespaceIndex = 0;

            // Set attributes
            this.GetNode().BrowseName  = "Cart";
            this.GetNode().DisplayName = "Cart";
            this.GetNode().Description = "";
            this.GetNode().WriteMask = AttributeWriteMask.None
                                        
                                        
                                        
                                        
                                        
                                        
                                        
                                        ;
                                        
            //Create Children objects
            
            {
            string childBrowseName = "Books";
    string childFileNoExtension = "type_ObjectType_Books_1752425740_0";
    string childSourceId = "Books_100000";
    ushort childSourceNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    string childTypeDefId = "Books_100000";
    int childTypeDefNamespaceIndex =  m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childTypeDefNodeIdType = 1;

    obj_Books_1752425740_0 = (ObjectType_Books_1752425740_0)                                                                                              
            (m_addressSpaceMgr.CreateObject(childrenIDMap,                                                              
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType));                                                            
    ObjectType_Books_1752425740_0 local = obj_Books_1752425740_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
       
            }
            
            {
            string childBrowseName = "User";
    string childFileNoExtension = "type_ObjectType_User_1876952222_0";
    string childSourceId = "User_100000";
    ushort childSourceNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    string childTypeDefId = "User_100000";
    int childTypeDefNamespaceIndex =  m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childTypeDefNodeIdType = 1;

    obj_User_1876952222_0 = (ObjectType_User_1876952222_0)                                                                                              
            (m_addressSpaceMgr.CreateObject(childrenIDMap,                                                              
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType));                                                            
    ObjectType_User_1876952222_0 local = obj_User_1876952222_0;
    m_addressSpaceMgr.AddPredefinedNodeExt(m_addressSpaceMgr.SystemContext, local.GetNode());
       
            }
            
            
            //Create Children variables
            
            {
            string childBrowseName = "Guid";
    string childFileNoExtension = "type_VariableType_Guid_706502738_0";
    string childTypeDefId = "63";
    ushort childTypeDefNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childTypeDefNodeIdType = 0;

    string childDataTypeId = "14";
    ushort childDataTypeNamespaceIndex =  (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("http://opcfoundation.org/UA/");
    ushort childDataTypeNodeIdType = 0;
    int childDataTypeValueRank = -1;
    string childDataTypeArrayDimension = "";

    string childSourceId = "Guid_100000";
    ushort childSourceNamespaceIndex = (ushort)m_addressSpaceMgr.SystemContext.NamespaceUris.GetIndex("TPUM");
    ushort childSourceNodeIdType = 1;
    NodeId newChildId = Helper.CreateID(childrenIDMap, m_addressSpaceMgr,
                                        childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType);

    var_Guid_706502738_0 = (VariableType_Guid_706502738_0)                                                                                            
            (m_addressSpaceMgr.CreateVariable(childrenIDMap,                                                            
                 this.GetNode(), childFileNoExtension, childBrowseName,                                                 
                 childSourceId, childSourceNamespaceIndex, (IdType)childSourceNodeIdType,             
	                newChildId.Identifier.ToString(), newChildId.NamespaceIndex, (IdType)newChildId.IdType, 
  	            m_nodeId, m_namespaceIndex, m_nodeIdType,                                                              
                 childDataTypeValueRank));                                                                              
    VariableType_Guid_706502738_0 local = var_Guid_706502738_0;
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
            public ObjectType_Books_1752425740_0 obj_Books_1752425740_0;
    public ObjectType_User_1876952222_0 obj_User_1876952222_0;


            /* Children variables */
            public VariableType_Guid_706502738_0 var_Guid_706502738_0;


            /* Children properties */
        

            /* Children methods */
        
        #endregion
    }
}
