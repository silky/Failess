﻿[<AutoOpen>]
module Failess.CSSModules
let internal (-) m p = m -- s p
module Border =
    let internal (-) p = (-) border p
    let none    = (-) Border.None
    let solid   = (-) Border.Solid
    let set  w t c =
        border ---- [w; s t; c]
module Color =
    let white   = "color: white;"
    let black   = "color: black;"
    let red     = "color: red;"
module Display =
    let internal (-) p = (-) display p
    let block = (-) Display.Block
    let Inline = (-) Display.Inline
module FontWeight =
    let internal (-) p = fontWeight -- s p
    let bold = (-) FontWeight.Bold
module FontVariant =
    let internal (-) p = (-) fontVariant p
    let smallCaps = (-) FontVariant.SmallCaps
module Float =
    let internal (-) p = (-) "float" p
    let left = (-) Float.Left
    let right = (-) Float.Right
module TextDecoration =
    let internal (-) p = (-) textDecoration p
    let none = (-) TextDecoration.None
module TextAlign =
    let internal (-) p = (-) textAlign p
    let center = (-) TextAlign.Center
    let left = (-) TextAlign.Left
    let right = (-)TextAlign.Right
