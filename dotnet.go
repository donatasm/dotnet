package dotnet

import "C"

// FortyTwo returns 42
//export FortyTwo
func FortyTwo() int32 {
	return 42
}
