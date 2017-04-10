(ns game.core
  (use arcadia.core
       hard.core)
  (:import [UnityEngine Component Debug Transform]))

;; state example
; (def cube (create-primitive :cube))

; (set-state! cube :friendly? true)
; (set-state! cube :health 100.0)

; (state cube)
; (state cube :friendly?)

; (remove-state! cube :friendly?)
; (state cube)
; (state cube :friendly?)

; (update-state! cube :health inc)
; (state cube)

(def camera (object-tagged "MainCamera"))
; (cmpts camera)
(def transform (cmpt camera UnityEngine.Transform))
; (->transform camera) ; equal
; (transform? transform)
(.position transform)
(.rotation transform)
; (.scale transform) ; not find such field
(.localScale transform)

(the "FirstPersonCharacter")

(def v3zero (->v3 0 0 0))

(look-at! (the "FirstPersonCharacter") v3zero)

; (position! camera v3zero) ; thats working!

