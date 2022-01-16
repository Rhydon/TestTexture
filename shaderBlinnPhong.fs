#version 330 core

in vec4 normal;
in vec3 half;
in vec3 lightdir;

layout(location=0) out vec4 fragmentColor;

uniform vec3 lightPosition;
uniform vec3 lightIntensity;

uniform vec3 Ia;
uniform vec3 ka, kd, ks;
uniform float phongExp;

void main(void)
{
	vec3 n = normalize(normal.xyz);
	vec3 h = normalize(half);
	vec3 l = normalize(lightdir);
	
	vec3 intensity = ka * Ia
					+ kd * lightIntensity * max( 0.0, dot(n, l) )
					+ ks * lightIntensity * pow( max( 0.0, dot(n, h) ), phongExp );
	fragmentColor = vec4( intensity, 1.0 );
}