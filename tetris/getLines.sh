#!/bin/bash

ls *.vb | grep -v Designer | xargs cat | wc -l
