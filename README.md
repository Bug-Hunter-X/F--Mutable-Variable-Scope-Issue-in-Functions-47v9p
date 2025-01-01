This example demonstrates a common mistake in F# when dealing with mutable variables within functions.  The initial values of `x` and `y` are used in `add`, even after they are changed outside the function.  The solution shows how to properly use `ref` parameters for modification within functions.