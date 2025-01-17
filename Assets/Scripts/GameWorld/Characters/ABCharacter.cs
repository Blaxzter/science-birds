// SCIENCE BIRDS: A clone version of the Angry Birds game used for 
// research purposes
// 
// Copyright (C) 2016 - Lucas N. Ferreira - lucasnfe@gmail.com
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>
//

using UnityEngine;
using System.Collections;

public class ABCharacter : ABGameObject {

    protected Animator _animator;
    public float _maxTimeToBlink;

    // Use this for initialization
    protected override void Awake () {

        base.Awake ();

        _animator = GetComponent<Animator>();
	
        float nextBlinkDelay = Random.Range(0.0f, _maxTimeToBlink);
        Invoke("Blink", nextBlinkDelay + 1.0f);
    }

    public bool IsIdle() {
		
        return _animator.GetCurrentAnimatorStateInfo(0).IsName("idle");
    }

    void Blink() {
		
        if(IsIdle())
            _animator.Play("blink", 0, 0f);
		
        float nextBlinkDelay = Random.Range(0.0f, _maxTimeToBlink);
        Invoke("Blink", nextBlinkDelay + 1.0f);
    }
}