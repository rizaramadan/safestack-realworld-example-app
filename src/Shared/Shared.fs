namespace Shared

open System

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

type UserLoginDto = {
    email:    string
    password: string
}
type LoginRequest = {
    user: UserLoginDto
}

type UserAuthDto = {
    Email:    string
    Token:    string
    Username: string
    Bio:      string
    Image:    string
}

type users = {
    login: LoginRequest -> Async<UserAuthDto>
}
