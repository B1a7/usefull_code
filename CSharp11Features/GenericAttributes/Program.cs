

public class EqualsAttribute<T> : Attribute
{
    public EqualsAttribute(T value)
    {
        Value = value;
    }
    public T Value { get; set; }
}


public class Person
{
    [EqualsAttribute<string>("Jakub")]
    public string Name { get; set; } = default!;

    [EqualsAttribute<int>(10)]
    public int Score { get; set; }

}



class Class1
{
    void Validate(Person person)
    {
        var propValue = prop.GetValue(person);

        var propType = prop.PropertyType;

        var equalsAttribute = prop.GetCutomAttribute(typeof(EqualsAttribute<>));

        if (equalsAttribute is not null && propValue is not null)
        {
            var equalsAttributeType = equalsAttribute.GetType().GetGenericArguments()[0];
            if (equalsAttributeType == typeof(string))
            {
                var attributeValue = ((EqualsAttribute<string>)equalsAttribute).Value;
                if (attributeValue != (string)propValue)
                {
                    throw new System.Exception($"Field { prop.Name} with value {propValue} != {attributeValue}");
                }
            }
        }
    }

}