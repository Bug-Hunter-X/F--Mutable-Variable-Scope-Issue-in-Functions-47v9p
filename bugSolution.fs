let mutable x = ref 10
let mutable y = ref 20
let add (x:int ref) (y:int ref) = !x + !y
printf "%d" (add x y)
x := 30
printf "%d" (add x y)