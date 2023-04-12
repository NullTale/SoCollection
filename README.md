# SoCollection
 
`SoCollection<>` is an generic type thet allows easily create and edit nested ScriptableObjects collections and groups them into a list.<br>It can be useful to create a polymorphic collections or some sort of action sequences.

![Demonstration](https://user-images.githubusercontent.com/1497430/231393793-d3eb0068-212c-4550-b6f6-422ce72583bd.gif)

## Notes
The base type must be abstract in order to have suggestions.

With `Shift` pressed, more advanced options appear to control the list (more for debugging purposes).<br>
* Empty records can be added.
* Shown suggestions to create inherited types (if the base type is not abstract).
* Records can be removed without destroying a linked object.
