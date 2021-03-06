//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Protos/LoginRole.proto
namespace Protos.LoginRole
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Data")]
  public partial class Data : global::ProtoBuf.IExtensible
  {
    public Data() {}
    
    private string _nickName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"nickName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string nickName
    {
      get { return _nickName; }
      set { _nickName = value; }
    }
    private int _profession;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"profession", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int profession
    {
      get { return _profession; }
      set { _profession = value; }
    }
    private bool _sex;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"sex", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool sex
    {
      get { return _sex; }
      set { _sex = value; }
    }
    private int _level;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _coin;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"coin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int coin
    {
      get { return _coin; }
      set { _coin = value; }
    }
    private int _gold;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"gold", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int gold
    {
      get { return _gold; }
      set { _gold = value; }
    }
    private int _life;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"life", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int life
    {
      get { return _life; }
      set { _life = value; }
    }
    private int _attack;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"attack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int attack
    {
      get { return _attack; }
      set { _attack = value; }
    }
    private int _defend;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"defend", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int defend
    {
      get { return _defend; }
      set { _defend = value; }
    }
    private int _magic;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"magic", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int magic
    {
      get { return _magic; }
      set { _magic = value; }
    }
    private int _agility;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"agility", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int agility
    {
      get { return _agility; }
      set { _agility = value; }
    }
    private int _speed;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"speed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int speed
    {
      get { return _speed; }
      set { _speed = value; }
    }
    private int _fortune;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"fortune", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fortune
    {
      get { return _fortune; }
      set { _fortune = value; }
    }
    private int _technique;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"technique", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int technique
    {
      get { return _technique; }
      set { _technique = value; }
    }
    private int _skillPoint;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"skillPoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int skillPoint
    {
      get { return _skillPoint; }
      set { _skillPoint = value; }
    }
    private int _status;
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private int _positionX;
    [global::ProtoBuf.ProtoMember(17, IsRequired = true, Name=@"positionX", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int positionX
    {
      get { return _positionX; }
      set { _positionX = value; }
    }
    private int _positionY;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"positionY", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int positionY
    {
      get { return _positionY; }
      set { _positionY = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginRoleReq")]
  public partial class LoginRoleReq : global::ProtoBuf.IExtensible
  {
    public LoginRoleReq() {}
    
    private int _characterId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"characterId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int characterId
    {
      get { return _characterId; }
      set { _characterId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LoginRoleRes")]
  public partial class LoginRoleRes : global::ProtoBuf.IExtensible
  {
    public LoginRoleRes() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }

    private Data _data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Data data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}