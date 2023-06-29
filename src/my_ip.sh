#!/bin/bash

api="https://api.myip.com"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"

function get_own_ip_info() {
	curl --request GET \
		--url "$api" \
		--user-agent "$user_agent"
}
