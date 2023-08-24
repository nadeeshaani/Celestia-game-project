### Gravity() method in SolarSystem.cs

``` C-sharp
void Gravity()
{
    foreach(GameObject a in celestials)
    {
        foreach(GameObject b in celestials)
        {
            if (!a.Equals(b))
            {
                float m1 = a.GetComponent<Rigidbody>().mass;
                float m2 = b.GetComponent<Rigidbody>().mass;
                float r = Vector3.Distance(a.transform.position, b.transform.position);

                a.GetComponent<Rigidbody>().AddForce((b.transform.position - a.transform.position).normalized * (G * (m1 * m2) / (r * r)));
            }
        }
    }
}
```

#### `foreach(GameObject a in celestials)`
- The outer loop
- It's used to calculate the gravitational force acting on each celestial obejct (a) due to the precense of other celestial objects.

#### `foreach(GameObject b in celestials)`
- The inner loop
- It's used to calculate the gravitational force between the current celestial object (a) and all other celestial objects (b)

#### `if (!a.Equals(b))`
- This line checks if the current celestial object 'a' is not the same as the current 'b'. Because we don't want the force between an object and iteself.

#### `float m1 = a.GetComponent<Rigidbody>().mass;`
- This line access the Rigidbody component of the object a, and take its mass property.
- Then saves it as the float m1

#### `float m2 = b.GetComponent<Rigidbody>().mass;`
- similarly, this line access the Rigidbody component of the object b, and take its mass property and saves it as m2.

#### `float r = Vector3.Distance(a.transform.position, b.transform.position);`
- This line calculates the distance between (the positions of) celestial objects a and b.
- What `Vector3.Distance` function does is measuring the Euclidean distance between two points in 3D space.
- Euclidean distance -> the distance between two points calculated using Pythogoream theorem.

#### `a.GetComponent<Rigidbody>().AddForce((b.transform.position - a.transform.position).normalized * (G * (m1 * m2) / (r * r)));`
- To understand this, let's look into some other theories, formulas behind this code line...

- ##### Newton's Law of Gravitation
          The formula F = (G * m1 * m2) / r^2 represents the gravitational force between two objects.
          F: Gravitational force between the objects.
          G: Universal gravitational constant.
          m1, m2: Masses of the two objects.
          r: Distance between the centers of the two objects.

- (b.transform.position - a.transform.position) calculates a vector pointing from a to b.
- `.normalized` converts this vector into a unit vector, which only represents the direction without magnitude.
- Then the normalized direction vector (representing the direction of the force) is multiplied by the magnitude of the force.
- AddForce method adds this force vector to the Rigidbody of object a, affecting its motion.






