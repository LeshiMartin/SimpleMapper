using System;

namespace SimpleMapperGenerator;
public interface IMainMapAttribute;

public class MapFrom<T> : Attribute,IMainMapAttribute where T : class;
public class MapTo<T> : Attribute,IMainMapAttribute where T : class;
public class MapFrom(string name) : Attribute,IMainMapAttribute;
public class MapTo(string name) : Attribute,IMainMapAttribute;
public class IgnoreMapping<T>():Attribute where T: IMainMapAttribute;
