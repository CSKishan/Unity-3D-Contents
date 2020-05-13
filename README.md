# Unity 3D Contents
On course, Unity Game Development

The repository is a cumulative work on Unity game development course.

## May 07, 2020  
Three Teddy Bears resizing project.  
### Concept used:  
Vector3 newScale = transform.localScale;  
newScale.x *(X coordinates)*  
newScale.y *(Y coordinates)*  
newScale.z *(Z coordinates)*  
  
newScale.x \*=3; *(expanding x measure by 3)*   
transform.localScale = newScale; *(saving the new size)*  
*Note: copy-change-copy methodology is used in C# as opposed to direct changes*   

## May 13, 2020
Physics in Unity
### Concepts used:
Rigidbody2D rb2d = GetComponent<Rigidbody2D>();  
rb2d.AddForce(new Vector2(1,0),  
  ForceMode2D.Impulse);  
  
  Vector2(1,0) : Move the object in the x-axis with 1 unit impulse.  
  ForceMode2D : Force used is of Impulse type.  
  AddForce() : Method to add force to the intended object.
  
