# SoCollection
 
Allows to create and edit nested ScriptableObject collections, automatically groups them into a list.

It can be useful to easily create polymorphic collections, such as a object modules, audio list or variables set for example.

https://user-images.githubusercontent.com/1497430/230766447-548b164f-5788-4aaa-bfc8-5c9b72c47137.mp4


> The base type must be abstract in order to have suggestions.


 ``` c#
 // container with a collection of scriptable objects derived from SoColor
public class SoColorsSet : ScriptableObject
{
    // The base type must be abstract in order to have suggestions.
    public SoCollection<SoColor> _collection;
}

// base type for the collection elements
public abstract class SoColor : ScriptableObject
{
    public abstract Color GetColor();
}
```

With `Shift` pressed, more advanced options appear to control the list.<br>
* Shown suggestions to create inherited types if the base type is not abstract.
* Objects are deleted without destroying the linked object.
* Empty items can be added.
 
