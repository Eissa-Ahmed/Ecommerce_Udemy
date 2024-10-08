﻿namespace Ecommerce.Infrastucture.Specification.Models.AttributeSpecification;

public sealed class AttributesSpecification : Specification<Attributes, Attributes>
{
    public AttributesSpecification(List<Expression<Func<Attributes, bool>>> criterias, bool applyTracking = false) : base()
    {
        //ApplyTracking(applyTracking);
    }
    public AttributesSpecification(List<Expression<Func<Attributes, bool>>> criterias, List<Expression<Func<Attributes, object>>> Includes, bool applyTracking = false) : base()
    {
        /*ApplyTracking(applyTracking);
        foreach (var Include in Includes)
        {
            AddInclude(Include);
        }*/
    }
    public AttributesSpecification(bool applyTracking = false)
    {
        //ApplyTracking(applyTracking);
    }

}

