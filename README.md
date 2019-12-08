# blazito

Small, easily configurable Automation Server

## Syntax

### FROM

Determines the base recipe from which to start.

`FROM <image> [AS <name>]`
`FROM --os=<system> [AS <name>]`

### RUN

Execute a command in the default shell.

`RUN <command>`

### SHELL

Sets the default shell for `RUN` commands.

`SHELL <command>`

### ADD

Add files to the output of the stage.

`ADD <path>`

### COPY

Copy files.

`COPY [--from=<stage>] <source> <destination>`

### WORKDIR

 Change the working directiory.

`WORKDIR <path>`
`WORKDIR DEFAULT`

### ARG

Define an input argument.

`ARG <name>[=<default>] [--options=<options>]`
