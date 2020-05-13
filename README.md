# Unity 3D Contents
On course, Unity Game Development

The repository is a cumulative work on Unity game development course.

## May 07, 2020  
Three Teddy Bears resizing project.  
### Concept used:  
```
Vector3 newScale = transform.localScale;  
newScale.x *(X coordinates)*  
newScale.y *(Y coordinates)*  
newScale.z *(Z coordinates)*  
```
  
newScale.x \*=3; *(expanding x measure by 3)*   
transform.localScale = newScale; *(saving the new size)*  
*Note: copy-change-copy methodology is used in C# as opposed to direct changes*   

## May 13, 2020
Physics in Unity
### Concepts used:
#### Movement of objects
```
Rigidbody2D rb2d = GetComponent\<Rigidbody2D\>();  
rb2d.AddForce( new Vector2(1,0),  
  ForceMode2D.Impulse );  
```
Vector2(1,0) : Move the object in the x-axis with 1 unit impulse.  
ForceMode2D : Force used is of Impulse type.  
AddForce() : Method to add force to the intended object.

#### Creating collisions

Giving max and min value to impulses.  
```
const float minImpulse = 3f;
const float maxImpulse = 5f;
float magnitude = UnityEngine.Random.Range(minImpulse, maxImpulse);
```  
Calculating a random angle for motion.  
```
float angle = UnityEngine.Random.Range(0, 2\*Math.PI);
```  
Choosing direction.  
```
Vector2 direction = new Vector2(
  Mathf.Cos(angle), Mathf.Sin(angle));
```
Apply the force.  
```
GetComponent<Rigidbody2D>().AddForce(
  direction*magnitude, 
  ForceMode2D.Impulse);
```
Creating colliders   
+ Box Collider 2D & Edge Collider 2D
+ Designing prefabs  

Handing collision (using method)  
```csharp
private void OnCollisionEnter2D(Collision2D coll)
{
  print("Collison occurred.");
}
```

  
  
  
